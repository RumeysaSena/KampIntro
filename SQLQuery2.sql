Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers 

Select * from Customers where City = 'Berlin'

--case insensitive/ büyük küçük harf duyarsız.
Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by ProductName

select * from Products order by CategoryID , ProductName

select * from Products order by UnitPrice asc -- ascending /artan

select * from Products order by UnitPrice desc -- descending /düşen

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) from Products -- Tüm satırları say demek. ürün katalogumuzda kaç tane ürün var demek gibi.

select count(*) Adet from Products -- Fromdan önce tabloda adını koymak istediğimiz ismi girebiliriz

select count(*) from Products where CategoryID=2 -- 2 numaralı kaç ürünümüz var 

--Hangi katogeride kaç farklı ürünümüz var ?

select categoryId from Products group by CategoryID   -- datalarımın içine bak bütün kategorileri tekrar etmeyecek şekilde sırala demek 
-- group by yaptığın zaman aslında her bir grup için arka planda bir tablo oluşturuluyormuş gibi düşünebilirsin. 

select categoryID , count(*)  Adet from Products group by CategoryID -- burada count(*) diyebiliriz .bu da her grup için örn; 1 numaralı kategoride 12 ürün, 3 num. kategoride 13 ürün şeklinde sıralar.

-- örn; ürün sayısı 10'dan az olan kategorileri listele denildiğinde ; (having)
select categoryID , count(*)  Adet from Products group by CategoryID having COUNT(*)<10

-- datayı filtrelemek istersek ; birim fiyatı 20'den fazla ürünleri CategoryID'ye göre grupla , onlardanda her bir grupta sayısı 10'dan az olanları sırala 
select categoryID , count(*)  from Products where UnitPrice>20  group by CategoryID having COUNT(*)<10


-- join(birleştrimek) CategoryId yerine categoryName getirmek daha doğru bu yüzden bu tabloları coinle birleştirirz.

select * 
from products inner join Categories --buradaki from tek başına products değil, hem products hemde kategorilerin bir araya getirilmiş şekli anlamına geliyor. 
on Products.CategoryID = Categories.CategoryID -- neye göre birleştirip yazılacağı koşulunu "on" ile yazarız. 

select Products.ProductID, Products.ProductName , Products.UnitPrice, Categories.CategoryName -- * tüm kolunlar demek. * yerine hangi kategoride neyi istediğimizi seçebiliriz.
from products inner join Categories
on Products.CategoryID = Categories.CategoryID 

--DTO Data Transformation Object- 

-- inner join sadece iki tablodada eşleşenleri bir araya getirir. eşleşmeyen data varsa onu getirmez.

select * from Products p inner join [Order Details] od -- boşluk isimlendirme standartlarında doğru değil, o yüzden farklı bir kodmuş gibi algılamasın diye SQL'de köşeli parantez içine alınır.
on p.ProductID = od.ProductID

-- örn ; hiç satış yapamadığımız ürünleri göster dersek; left join , solda olup(ürünler tablosunda var ama hiç satış yok ) sağda olmayanları da getir demek.
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

-- örn sistemimize kayıt olup hiç sipariş girişi yapılmamış müşreilere özel kampanya vs yapılmak isteniyor. aktif müşteri ;
select * from Customers c left join Orders o -- (solda(customer) olup sağda(sipariş) olmayanları da (müşteride olup siparişte olmayanları)
on c.CustomerID=o.CustomerID

-- tam olarak o müşterileri bulmak içinse ;
select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null -- null : data yok

--ikiden fazla tabloyu join etmek istersek
select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o -- bir join daha eklemek istiyorsak devamına bir inner join daha ekleriz. 
on o.OrderID=od.OrderID 