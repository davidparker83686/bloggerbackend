-- CREATE TABLE accounts (
--    id VARCHAR(255) NOT NULL,
--    name VARCHAR(255) NOT NULL,
--    email VARCHAR(255) NOT NULL,
--    picture VARCHAR(255) NOT NULL,
--    PRIMARY KEY (id)
-- );

-- CREATE TABLE blogs (
--   id INT NOT NULL AUTO_INCREMENT,
--   creatorId VARCHAR(255) NOT NULL,
--   title VARCHAR(255) NOT NULL,
--   body VARCHAR(255) NOT NULL,
--   imgUrl  VARCHAR(255) NOT NULL,
--   published BOOLEAN NOT NULL,
--   PRIMARY KEY (id),
--   FOREIGN KEY (creatorId)
--   REFERENCES accounts (id)
--   ON DELETE CASCADE
-- ); 

-- CREATE TABLE comments (
--   id INT NOT NULL AUTO_INCREMENT,
--   blog INT NOT NULL ,
--   creatorId VARCHAR(255) NOT NULL,
--   body VARCHAR(255) NOT NULL,

--   PRIMARY KEY (id),
--   FOREIGN KEY (blog)
--   REFERENCES blogs (id),
--   FOREIGN KEY (creatorId)
--   REFERENCES accounts (id)
--   ON DELETE CASCADE
-- ); 