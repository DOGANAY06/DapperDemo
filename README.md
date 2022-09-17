# DapperDemo
Dapper Ornegi Yapıldı Solvera Stajındayken
15.08.2022 
Bugün Dapper öğrenmeye başladım. Dapper orm aracıdır. Orm ise Database ile model sınıflar arasında ilişki kurarak eşleşmeyi
sağlayan araçtır. Dapper kullanmamızdaki amaç hızlı, hafif, kolay ve tip dönüşüm bağımlılığının olmaması. 
Yani doğrudan bir sql sorgusu yapıp .toList() metodu ile sorgu sonucunu herhangi bir Poco, Dto, model, dynamic ile 
dönebilirsiniz. Bu sayede işler çok daha hızlı ilerler. Aynı şekilde veriyi kabul ederken de bir modeli olduğu gibi 
atabilirsiniz ya da sql sorgusu oluşturacak şekilde string birleştirme de yapabilirsiniz. CRUD işlemlerinde kolaylık sağlar.  
Dapperle ilgili bir uygulama yaptım uygulamada ki amacım form nesnesi ile company ekleme, silme, düzenleme,
detaylarını gösterme işlemleri yaptım. Veritabanını oluşturmak için entity framework code first yöntemini kullandım. 
