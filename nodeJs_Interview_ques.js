// Node.js + Express.js Interview Questions and Answers with Code Examples

/*
1. What is Node.js?
*/
// Node.js is a JavaScript runtime built on Chrome's V8 engine.

/*
2. Difference between Node.js and Browser JavaScript?
*/
// Node.js runs on the server and has access to the file system, while browser JS runs in a sandbox.

/*
3. What is NPM?
*/
// NPM is the default package manager for Node.js, used to install dependencies.

/*
4. What is package.json?
*/
// It manages project metadata and dependencies.

/*
5. Creating an HTTP Server in Node.js
*/
const http = require('http');
http.createServer((req, res) => {
  res.writeHead(200, { 'Content-Type': 'text/plain' });
  res.end('Hello World');
}).listen(3000);

/*
6. What is Express.js?
*/
// Express is a lightweight framework for building web applications in Node.js.

/*
7. Benefits of Express.js
*/
// Simpler routing, middleware support, faster development.

/*
8. Define Routes in Express
*/
const express = require('express');
const app = express();
app.get('/', (req, res) => res.send('Home Page'));

/*
9. What is Middleware in Express?
*/
// Middleware are functions executed in the request-response cycle.
app.use(express.json()); // Example middleware

/*
10. Use of app.use()
*/
app.use('/api', (req, res, next) => {
  console.log('API Middleware');
  next();
});

/*
11. How Routing Works
*/
app.get('/about', (req, res) => res.send('About Page'));

/*
12. app.use() vs app.get()
*/
// app.use() applies middleware. app.get() defines GET route.

/*
13. Order of Middleware
*/
// Order matters, first middleware executes first.

/*
14. Handle 404 Error
*/
app.use((req, res) => {
  res.status(404).send('404 Not Found');
});

/*
15. Types of Middleware
*/
// Application-level, Router-level, Error-handling, Built-in, Third-party

// Application-level:
app.use((req, res, next) => {
  console.log('Global Middleware');
  next();
});

// Router-level:
const router = express.Router();
router.use((req, res, next) => {
  console.log('Router Middleware');
  next();
});

// Error-handling:
app.use((err, req, res, next) => {
  console.error(err.message);
  res.status(500).send('Server Error');
});

/*
16. CRUD with Express
*/
let users = [];
app.post('/users', (req, res) => {
  users.push(req.body);
  res.status(201).send('User Created');
});
app.get('/users', (req, res) => res.json(users));
app.put('/users/:id', (req, res) => {
  users[req.params.id] = req.body;
  res.send('User Updated');
});
app.delete('/users/:id', (req, res) => {
  users.splice(req.params.id, 1);
  res.send('User Deleted');
});

/*
17. HTTP Status Codes
*/
// 201: Created, 204: No Content, 400: Bad Request, 404: Not Found, 500: Internal Server Error

/*
18. Global Error Handling
*/
app.use((err, req, res, next) => {
  console.error(err.stack);
  res.status(500).send('Something broke!');
});

/*
19. express.json() and body-parser
*/
// express.json() is built-in to parse JSON request bodies.

/*
20. Security Middleware
*/
const helmet = require('helmet');
const cors = require('cors');
app.use(helmet());
app.use(cors());

/*
21. Environment Variables
*/
// Use dotenv
require('dotenv').config();
console.log(process.env.PORT);

/*
22. Event Loop
*/
// The event loop handles asynchronous callbacks in Node.js.

/*
23. Callback Hell
*/
// Nesting callbacks can be messy. Use Promises or async/await to fix.

/*
24. Async/Await
*/
async function fetchData() {
  const data = await getData();
  console.log(data);
}

/*
25. Streams
*/
const fs = require('fs');
const stream = fs.createReadStream('file.txt');
stream.on('data', chunk => console.log(chunk));

/*
26. process.nextTick() vs setImmediate() vs setTimeout()
*/
// process.nextTick() executes before any I/O events.
// setImmediate() executes after I/O events.
// setTimeout(fn, 0) executes after a minimum delay.
process.nextTick(() => console.log('nextTick'));
setImmediate(() => console.log('immediate'));
setTimeout(() => console.log('timeout'), 0);

/*
27. Large File Upload
*/
// Use multer or formidable modules

/*
28. Prevent SQL Injection/XSS
*/
// Use parameterized queries, sanitize inputs

/*
29. Rate Limiting
*/
const rateLimit = require('express-rate-limit');
const limiter = rateLimit({ windowMs: 1 * 60 * 1000, max: 5 });
app.use(limiter); // Limits each IP to 5 requests per minute

/*
30. Deploying Express App
*/
// Use PM2 or Docker for production. Deploy to Heroku, AWS, etc.

/*
31. Connect to DB (MongoDB example)
*/
const mongoose = require('mongoose');
mongoose.connect('mongodb://localhost/test');

/*
32. Project Structure
*/
// routes/, controllers/, models/, config/

/*
33. Sync vs Async DB calls
*/
// Async is non-blocking, preferred in Node.js

/*
34. Connection Pooling
*/
// DB driver maintains multiple connections for better performance

/*
35. Login System
*/
// Use bcrypt for hashing, JWT for tokens
const bcrypt = require('bcrypt');
const jwt = require('jsonwebtoken');
const usersDB = [];
app.post('/register', async (req, res) => {
  const hashedPassword = await bcrypt.hash(req.body.password, 10);
  usersDB.push({ username: req.body.username, password: hashedPassword });
  res.send('Registered');
});
app.post('/login', async (req, res) => {
  const user = usersDB.find(u => u.username === req.body.username);
  if (user && await bcrypt.compare(req.body.password, user.password)) {
    const token = jwt.sign({ username: user.username }, 'secret');
    res.json({ token });
  } else {
    res.status(401).send('Unauthorized');
  }
});

/*
36. Pagination
*/
// Use limit and skip in DB query

/*
37. Send Email
*/
const nodemailer = require('nodemailer');

/*
38. Unit Tests
*/
// Use Mocha, Chai, Supertest

/*
39. File Uploads
*/
// Use multer middleware

/*
40. Logging
*/
const morgan = require('morgan');
app.use(morgan('dev'));
// Logging is used to track application activity, errors, and requests.
// Example: storing logs in files using Winston
const winston = require('winston');
const logger = winston.createLogger({
  transports: [
    new winston.transports.File({ filename: 'combined.log' }),
    new winston.transports.Console()
  ]
});
logger.info('App started');

module.exports = app;
