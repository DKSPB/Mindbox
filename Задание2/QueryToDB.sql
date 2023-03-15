select p.Name, c.Name from Product as p
inner join ProductCategory as pc on p.Id = pc.ProductId
inner join Category as c on pc.CategoryId = c.Id
where p.Name = N'Миксер'