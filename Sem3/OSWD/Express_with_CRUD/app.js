//post normalization
//decompose the application
const express = require('express');  
const app = express();
app.use(express.urlencoded({ extended: true })); //processing database in post method

const cors = require('cors');  
app.use(cors()); //cross origin resource sharing
// app.use(morgan('tiny')); //for parsing multipart/form-data
//this is for parsing JSON data .this app.use are not writen to payal mem
app.use(express.json());

require('dotenv').config(); //environment variables
//console.log(process.env.PORT);
const mongoose = require("./config/db");
require("./config/db"); //database connection
const Book =require("./models/Book")
    

const router = require('./routers/BookRoute'); //router middleware
const morgan = require('morgan');
app.use('/books', router);

    const PORT = process.env.PORT || 8000;
app.listen(PORT,(err)=>{
    console.log(`App is running on port no ${PORT}.`)
});