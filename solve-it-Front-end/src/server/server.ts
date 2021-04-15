import axios from "axios";

const baseURI = 'https://localhost:3000/';
const headers = { "Content-Type": "application/json" };
const URLS = {
    createUser: 'Authentication',
}

export const createUser = (obj: any) => {
    Post(baseURI+URLS.createUser, obj);
}


const Get = (url) => {
    axios.get(url)
        .then(response => {
            return response;
        })
        .catch(error => {
            return error;
        });
}

const Post = (url, obj) => {
    axios.post(url, {
        body: obj
    })
        .then(response => {
            return response;
        })
        .catch(error => {
            return error;
        });
}
