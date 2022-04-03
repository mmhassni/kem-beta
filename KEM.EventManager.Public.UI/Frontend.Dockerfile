### STAGE 1: Build ###
FROM node:12-alpine as builder

COPY frontend/package.json frontend/package-lock.json ./

## Storing node modules on a separate layer will prevent unnecessary npm installs at each build
RUN npm i -f && mkdir /ng-app && cp -R ./node_modules ./ng-app
WORKDIR /ng-app
COPY frontend/ .

RUN npm install -g --unsafe-perm node-sass
RUN npm run build

### STAGE 2: Setup ###
FROM nginx:alpine

## Remove default nginx website
RUN rm -rf /usr/share/nginx/html/*

## From ‘builder’ stage copy over the artifacts in dist folder to default nginx public folder
COPY --from=builder /ng-app/dist/frontend /usr/share/nginx/html

CMD ["nginx", "-g", "daemon off;"]