const express = require("express");
const app = express();
const cors = require("cors");
const router = express.Router();

router.use(
  require('./headerparser/index'),
  require('./urlshortener/index'),
  require('./filemetadata/index'),
  require('./express/index'),
  require('./timestamp/index'),
  require('./contact/index'),
  require('./exercisetracker/index')
);

app.use(
  "/api", 
  cors({ optionsSuccessStatus: 200 }),
  router
);

var listener = app.listen(process.env.PORT || 3000, function () {
  console.log("Your app is listening on port " + listener.address().port);
});