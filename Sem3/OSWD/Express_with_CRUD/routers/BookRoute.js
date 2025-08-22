const router = require('express').Router();
const Book = require('../models/Book');


router.get("/",(req,res)=>{
    //Get all
    console.log("Get all books");
        Book.find({})
            .then(( books)=> {
                res.send(books);
            })
            .catch((err)=>{
                res.status(400).send("ERR")
            })
    });
    router.get("/:id",(req,res)=>{
        console.log("Get one book");
        //Get one req.params.id
        Book.findById({"_id":req.params.id})
            .then((book)=>{
                if (!book) return res.status(404).send(
                    "No data found.");
                res.status(200).send(book);
            })
            .catch((err)=>{
                if (err) return res.status(500).send(
                    "There was a problem finding.");
            })
   
    });
   
   
    router.post("/",function(req,res){
        //INSERT    
        console.log("Insert a book");
        console.log(req.body)
        var book1 = new Book({
                name : req.body.name,
                price : req.body.price,
                quantity : req.body.quantity
            });
        book1.save()
            .then((book)=>{       res.status(200).send(book);        })
            .catch((err)=>{if (err) return console.error(err);})
    })
   
   
    router.put("/:id",(req,res)=>{
    //UPDATE  req.params.id, req.body
   console.log("Update a book");
        Book.findOneAndUpdate({"_id":req.params.id}, req.body,{new: true})
            .then((book)=>{res.status(200).send(book);})
            .catch((err)=>{
                if (err) return res.status(500).send(
                    "There was a problem updating.");
            })
    });
   
    router.delete("/:id",(req,res)=>{
    //DELETE req.params.id deleteOne() deleteMany() findOneAndDelete()
    console.log("Delete a book");
        Book.findOneAndDelete({"_id":req.params.id})
            .then((book)=>{
                res.status(200).send(book);
            })
            .catch((err)=>{
                if (err) return res.status(500).send(
                    "There was a problem deleting.");
            })
    });

    module.exports = router;