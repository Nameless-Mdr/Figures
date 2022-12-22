select p.name product, COALESCE(c.name, ' ') categorie
from products p left join pr_ct pc on p.id = pc.pr_id
left join categories c on pc.ct_id = c.id
order by p.id;
