 select a.cgst,a.sgst,a.igst from productgstdetails a inner join productcategory b on
a.product_gst_id = b.product_gst_id where b.Product_Type_Name = 'AC and Fridge'