/* Mark separated paragraphs one by one and press F5 to execute them separately. */
/* ATTENTION! You may have to change the post id depending on your database. */

INSERT INTO Posts(Title, Body, AuthorID, Date)
VALUES ('Random Title', 'Random Body', 2, CAST('2016-06-04' AS DateTime))

UPDATE Posts
SET Title = 'New Title'
WHERE ID = 32

DELETE FROM Posts
WHERE ID = 32