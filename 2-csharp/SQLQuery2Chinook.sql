--1.





--2. 





--3.




--4. 




--5. 
select  count (*), sum(total)
from invoice
where year (invoicedate) = 2009;

--6.




--7. 
Select BillingCountry, count(*)
from invoice
group by BillingCountry

--8. 
select BillingCountry, count(invoiceid) as 'sales count'
from invoice
group by billingcountry
order by count(invoiceid) desc;

--insert into table_name (column1,column2,column3,...)
--values (value1, value2, value

-- 1. show all invoices of customers from brazil (mailing address not billing)
-- 2. show all invoices together with the name of the sales agent of each one
-- 3. show all playlists ordered by the total number of tracks they have
-- 4. which sales agent made the most in sales in 2009?
-- 5. how many customers are assigned to each sales agent?
-- 6. which track was purchased the most since 2010?
-- 7. show the top three best-selling artists.
-- 8. which customers have the same initials as at least one other customer?





-- 1. which artists did not make any albums at all?
-- 2. which artists did not record any tracks of the Latin genre?
-- 3. which video track has the longest length? (use media type table)
-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)
-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?
-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.

