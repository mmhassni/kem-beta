FROM node:12-alpine as builder
COPY KEM.EventManager.Public.UI/package.json KEM.EventManager.Public.UI/package-lock.json ./
RUN npm i -f && mkdir /angularapp && cp -R ./node_modules ./angularapp
WORKDIR /angularapp
COPY . .
RUN npm install -g --unsafe-perm node-sass
RUN npm run build


FROM nginx:alpine
RUN rm -rf /usr/share/nginx/html/* 
COPY --from=builder /angularapp/dist/frontend /usr/share/nginx/html
CMD ["nginx", "-g", "daemon off;"]