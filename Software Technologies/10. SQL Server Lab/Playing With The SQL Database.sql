/* 15. Count of Users Having a Post in a Specified Date */
SELECT COUNT(*) AS UsersCount FROM Users
WHERE ID IN (SELECT AuthorId FROM Posts WHERE Date = CAST('2016-06-14' AS DateTime))

/* 16. Extract and Order All the Posts in a Specified Date */
SELECT * FROM Posts
WHERE Date = CAST('2016-06-14' AS DateTime)
ORDER BY AuthorId

/* 17. Find the Earliest Post from a Specified User */
SELECT * FROM Posts
WHERE Date = (SELECT MIN(Date) FROM Posts
	WHERE AuthorId = 2)

/* 18. Play with Comments */
SELECT * FROM Comments c JOIN Posts p ON c.PostId = p.ID
ORDER BY AuthorName ASC, c.ID DESC