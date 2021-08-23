FROM node:14.17.0-alpine as build

RUN mkdir -p /app
WORKDIR /app

COPY package.json /app
RUN npm install

COPY . /app
RUN npm run build --prod

FROM nginx:1.20.1
COPY --from=build /app/dist/spa /usr/share/nginx/html
EXPOSE 80

COPY nginx.conf /etc/nginx/nginx.conf
CMD ["nginx", "-g", "daemon off;"]
