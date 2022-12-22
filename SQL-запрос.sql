select p.name, c.name
from products p 
left join prod_categ pc on p.id = pc.product_id
left join categories c on pc.category_id = c.id
order by p.name
