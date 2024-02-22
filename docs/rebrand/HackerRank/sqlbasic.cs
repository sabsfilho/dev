void Main()
{
	
}

// Define other methods and classes here
/*


--select carteiraid, usuarioid, nome into #t from neg.carteira


--select a-b from (select count(*) a from (select usuarioid from #t) a) a, (select count(*) b from (select distinct usuarioid from #t) b) b

--select * from (select top 1 nome, len(nome) q from #t order by 2, 1) a union select * from (select top 1 nome, len(nome) q from #t order by 2 desc, 1) b


--select distinct nome from #t a where CHARINDEX(left(nome,1),'AEIOU', 1) > 0

--select distinct nome from #t a where CHARINDEX(right(nome,1),'AEIOU', 1) > 0


--select distinct nome from #t a where CHARINDEX(left(nome,1),'AEIOU', 1) > 0 and CHARINDEX(right(nome,1),'AEIOU', 1) > 0

--select distinct nome from #t a where CHARINDEX(left(nome,1),'AEIOU', 1) = 0--

select distinct nome from #t a where CHARINDEX(right(nome,1),'AEIOU', 1) = 0

select name + '(' + left(occupation,1) + ')' from occupations order by 1;
select 'There are a total of ' + cast(count(*) as varchar) + ' ' + lower(occupation) + 's.' from occupations group by occupation order by count(*);

select 
Doctor.name,
Professor.name,
Singer.name,
Actor.name
from
(select ROW_NUMBER() over (order by name) id, name from OCCUPATIONS where occupation = 'Professor') Professor
full join 
(select ROW_NUMBER() over (order by name) id, name from OCCUPATIONS where occupation = 'Actor') Actor
on Professor.id = Actor.id
full join 
(select ROW_NUMBER() over (order by name) id, name from OCCUPATIONS where occupation = 'Singer') Singer
on Professor.id = Singer.id
full join 
(select ROW_NUMBER() over (order by name) id, name from OCCUPATIONS where occupation = 'Doctor') Doctor
on Doctor.id = Professor.id

select distinct
e.company_code,
c.founder,
count(distinct e.lead_manager_code) lm,
count(distinct e.senior_manager_code) sm,
count(distinct e.manager_code) m,
count(distinct e.employee_code) e
from employee e
inner join company c on e.company_code = c.company_code
group by e.company_code,c.founder
order by 1

=== binary

select distinct
    x.n,
    iif(x.p is null,'Root',iif(i.n is not null,'Inner','Leaf'))
from bst x
left join bst i on i.p = x.n 

=== interviews
select 
c.contest_id, c.hacker_id, c.name,
isnull(total_submissions,0) total_submissions,
isnull(total_accepted_submissions,0) total_accepted_submissions,
isnull(total_views,0) total_views,
isnull(total_unique_views,0) total_unique_views
from contests c
left join
(
select 
x.contest_id,
sum(s.total_submissions) total_submissions,
sum(s.total_accepted_submissions) total_accepted_submissions
from colleges x
inner join Challenges y on y.college_id  = x.college_id 
inner join Submission_Stats s on s.challenge_id = y.challenge_id
group by x.contest_id
) x on x.contest_id = c.contest_id
left join
(
select 
x.contest_id,
sum(s.total_views) total_views,
sum(s.total_unique_views) total_unique_views
from colleges x
inner join Challenges y on y.college_id  = x.college_id 
inner join view_stats s on s.challenge_id = y.challenge_id
group by x.contest_id
) y on y.contest_id = c.contest_id
where 
(isnull(total_submissions,0) +
isnull(total_accepted_submissions,0) +
isnull(total_views,0) +
isnull(total_unique_views,0)) > 0
order by 1

=========

weather observation 20
declare @r int 
select @r=count(*)/2 from station

declare @t table (q int, lat_n decimal(10,4))
insert into @t(q, lat_n)
select ROW_NUMBER() over (order by lat_n) q, lat_n from station order by lat_n

select lat_n from @t where q = @r + 1

======
triangle
declare @i int set @i = 2
declare @x varchar(max) set @x = ''

while @i < 20
begin
select rtrim(@x)
set @i = @i + 1
end

============

prime

declare @i int set @i = 2
declare @x varchar(max) set @x = '2'
declare @j int set @j = 2
declare @w int set @w = 0

while @i < 1000
begin
set @w = 0
set @j=2
while @j < @i
begin
if @i > 1 and (@i % @j = 0) 
begin
set @j=10000
set @w = 0
end
else
begin
    set @w = 1
end
set @j = @j + 1
end

if @i > 1 and @w = 1
begin
    if (len(@x) > 0) 
    begin
        set @x = @x + '&'        
    end
    set @x = @x + cast(@i as varchar(max))
end

set @i = @i + 1
end
print @x



SELECT *
FROM @t p  
PIVOT  
(
	min(occupation) for occupation in (Actor,Doctor,Professor,Singer)
)AS t


SELECT *
FROM  @t  
UNPIVOT  
   (Orders FOR Employee IN   
      (name,occupation)
) t
