USE burgershack20;


--     CREATE TABLE burgers (

-- id int NOT NULL AUTO_INCREMENT,
-- name VARCHAR(255) NOT NULL,
-- description VARCHAR(255),
-- price DECIMAL DEFAULT 0,
-- PRIMARY KEY (id)
-- );

--     CREATE TABLE fries (

-- id int NOT NULL AUTO_INCREMENT,
-- name VARCHAR(255) NOT NULL,
-- description VARCHAR(255),
-- price DECIMAL DEFAULT 0,
-- PRIMARY KEY (id)
-- );

-- INSERT INTO burgers (name, description) VALUES ("Bubba", "Ground hot dog and 4 cheeses");
-- INSERT INTO burgers (name, description, price) VALUES ("Hondo", "Pork patty with smelly cheese",4.99);
-- INSERT INTO burgers (name, description, price) VALUES ("Vagabond", "Mashed pretzels with sardines and velveeta",7.99);

-- INSERT INTO fries (name, description, price) VALUES ("Curly", "Look like rat tails",2.99);
-- INSERT INTO fries (name, description, price) VALUES ("Seasoned", "Bascially salty",3.99);
-- INSERT INTO fries (name, description, price) VALUES ("Fancy", "Purple potato",5.99);





-- NOTE Edit
-- UPDATE burgers
-- SET
-- name = "Fish O'Filet",
-- price = 13.01
-- WHERE id = 2;

-- DELETE FROM burgers WHERE id = 1;
-- SELECT * FROM burgers
-- SELECT * FROM burgers WHERE id = 2;

-- NOTE Edit
-- UPDATE fries
-- SET
-- name = "Cajun Salt",
-- price = 4.99
-- WHERE id = 2;

-- DELETE FROM fries WHERE id = 1;
-- SELECT * FROM fries
-- SELECT * FROM fries WHERE id = 2;

-- BurgerFries
-- CREATE TABLE burgerfries (
--     id int NOT NULL AUTO_INCREMENT,
--     burgerId int NOT NULL,
--     friesId int NOT NULL,
--     PRIMARY KEY (id),

--     FOREIGN KEY (burgerId)
--         REFERENCES burgers(id)
--         ON DELETE CASCADE,

--     FOREIGN KEY (friesId)
--         REFERENCES fries(id)
--         ON DELETE CASCADE
-- )

-- INSERT INTO burgerfries (burgerId, friesId) VALUES (1, 1);
-- INSERT INTO burgerfries (burgerId, friesId) VALUES (1, 2);

-- JOIN TABLE QUERY (Fries Id => burgers)
SELECT * FROM burgerfries bfs
JOIN burgers b ON b.id = bfs.burgerId
WHERE friesId = 1;