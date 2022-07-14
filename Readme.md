## This is test challenge for Mindbox
All tests passed
For add new shape needs to implement IShape interface
## Second challenge answer
select p.name as ProductName, c.name as CategoryName from products p
left join product_category pc on p.id = pc.product_id
left join categories c on c.id = pc.category_id

