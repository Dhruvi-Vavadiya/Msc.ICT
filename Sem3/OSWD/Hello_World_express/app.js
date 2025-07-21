// console.log('Hello, World!');
const express = require('express');
const fs = require('fs')
const app=express()

const product_router = require('./routes/product'); //router middleware
app.use('/product', product_router);

// app.use('/',(req,res,next)=>{ //application middleware
//   console.log(`${req.method} request for '${req.url}'`);
//   next();
// });

app.get('/page2',function(req,res,next){
  fs.readFile("./filename.txt","utf-8",(err,data)=>{
    if(err){
      res.status(500).send("Error reading file");
    } else {
      res.send(data);
    }
  })
})

app.get('/page1', (req, res) => {
  res.send('Hello, World!');
});
app.listen(8000);
// app.listen(8000, () => {
//   console.log(`Server is running at http://localhost:8000`);
// }); 
  
