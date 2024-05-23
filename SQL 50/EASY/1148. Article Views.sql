-- What i have Done
select distinct a.author_id as id
from Views as a
inner join Views as b on a.author_id = b.viewer_id
where a.author_id = b.author_id
order by a.author_id;



-- After Viewing Others Solution.
SELECT DISTINCT author_id AS id
FROM Views
WHERE author_id=viewer_id
ORDER BY author_id;