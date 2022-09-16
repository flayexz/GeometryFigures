SELECT prod.name, categ.name 
FROM products AS prod 
        LEFT JOIN productsCategorys AS prodCateg 
            ON prod.id = prodCateg.productId 
        LEFT JOIN categorys AS categ 
            ON prodCateg.categoryId = categ.Id