const mongoose = require('mongoose');
// mongoose.connect(process.env.DBURL);
mongoose.connect("mongodb://localhost:27017/db");
const db = mongoose.connection;
//mongoose.set('useFindAndModify', false);
db.on('error', console.error.bind(console, 'connection error:'));
db.once('open', function() {
  console.log("Connected to the database successfully.");
});

module.exports = mongoose;

//ejs view
//jamstack view with express js // with apche server