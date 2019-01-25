Select a.Name, ISNULL(e.cat, '')
from Products a Left Join (select STRING_AGG(a.CategoryName,' ') cat, b.ProductId from CategoryName a, ProductsToCategory b
where a.Id=b.CategoryId
group by b.ProductId) as e
on a.Id = e.ProductId

