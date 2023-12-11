select*from Products
select*from Manufactures
select*from Categories
select*from Providers

create view v_Product
as
select Products.ProductID,Products.ProductName,Products.ProductDesc,Products.ProductCost,Products.ProductCount,Providers.ProviderName,Manufactures.ManufactureName,Categories.CategoryName
from Products inner join Providers on Products.ProviderID = Providers.ProviderID
inner join Manufactures on Products.ManufactureID = Manufactures.ManufactureID
inner join Categories on Products.CategoryID = Categories.CategoryID
select*from v_Product where ProductID = '1'

create proc sp_Load_2
@filter nvarchar(255),@sort nvarchar(255),@search nvarchar(max)
as
begin
	select*from v_Product
	where (@filter = 'Все производители' or ManufactureName like '%'+@filter+'%')
	and (ProductName like '%'+@search+'%' 
	or ProductDesc like '%'+@search+'%' 
	or ProductCost like '%'+@search+'%'  
	or ProductCount like '%'+@search+'%' 
	or ProviderName like '%'+@search+'%' 
	or ManufactureName like '%'+@search+'%' 
	or CategoryName like '%'+@search+'%')
	order by 
	case when @sort = '1' then ProductCount else null
	end asc,
	case when @sort = '2' then ProductCount else null
	end desc,
	case when @sort = '3' then ProductCost else null
	end asc,
	case when @sort = '4' then ProductCost else null
	end desc;
end;
execute sp_Load_2 'Все производители','',''

alter proc sp_AddUpdate1
@select nvarchar(255),@id int,@name nvarchar(255),@desc nvarchar(max),@cost int,@count int,@provider int,@manuf int,@category int
as
begin
	if @select = 'Add' 
	begin
		insert into Products(ProductName,ProductDesc,ProductCost,ProductCount,ProviderID,ManufactureID,CategoryID)
		values (@name,@desc,@cost,@count,@provider,@manuf,@category)
	end
	if @select = 'Update'
	begin
		update Products
		set ProductName = @name,
		ProductDesc = @desc,
		ProductCost = @cost,
		ProductCount = @count,
		ProviderID = @provider,
		ManufactureID = @manuf,
		CategoryID = @category
		where ProductID = @id
	end
end;
execute sp_AddUpdate1 'Update','39','test123','test123','2','2','1','1','1'
select*from v_Product where ProductID = '39'

create proc sp_Delete
@id int
as
begin
	delete Products where ProductID = @id
end;
execute sp_Delete '35'