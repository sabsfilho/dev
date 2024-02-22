declare @dts table(dt date)
declare @sbs table(dt date, hid int, q int)
declare @sbmx table(dt date, hid int, n varchar(max))
declare @sbh table(dt date, q int)

insert into @dts(dt)
select distinct submission_date dt
from Submissions x
group by submission_date 

insert into @sbs(dt, hid, q)
select submission_date dt, hacker_id, count(submission_id) q
from @dts t
inner join Submissions y on t.dt = y.submission_date
group by submission_date, hacker_id

insert into @sbmx(dt, hid, n)
select t.dt, z.hid, h.name 
from @dts t
inner join (
select t.dt, min(sbs.hid) hid
from @dts t
inner join (
    select dt, max(q) q
    from @sbs
    group by dt
) sbs2 on t.dt = sbs2.dt
inner join @sbs sbs on t.dt = sbs.dt and sbs2.q = sbs.q
group by t.dt
) z on z.dt = t.dt
inner join Hackers h on z.hid = h.hacker_id

insert into @sbh(dt, q)
select dt, count(hid)
from (
select dt, hid,
(select count(*) from @dts t where t.dt <= sbs.dt) d,
(select count(*) from @sbs z where sbs.hid = z.hid and z.dt <= sbs.dt) h
from @sbs sbs
) u 
where u.d = u.h
group by dt

select s.dt, s.q, x.hid, x.n
from @sbh s
inner join @sbmx x on s.dt = x.dt
order by 1