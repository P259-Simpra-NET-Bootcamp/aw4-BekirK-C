# Ödev-4
## Ödev İçeriği
- Projede eksik olarak birakilan DapperRepository class in implemantasyonunu tamamlayiniz. 
- Insert Update Delete GetAll,GetById methodlari ile calisacak halde methodlari implement edininiz. 
- Category modeli icin dapper servis hazirlayiniz. Bu servis Dynamic Dapper repository ile calisacak halde olmali. 
- Bu servis icin standart bir controller implement ediniz. (GetAll,GetById,Insert,Update,Delete) 
- Projede kullanilan tum DI islemlerini autofac ile olacak sekilde degistiriniz. 
- TransactionReportController dapper yerine EF ile calisacak sekilde guncelleyiniz.
> Tüm istekler karşılandı. 

## Program İçeriği
- Data>Repository>Dapper içerisinde DapperRepository sınıfında Insert, Update, Delete, GetAll ve GetById metotları Generic yapıya uygun şekilde implemente edildi.

![image](https://github.com/P259-Simpra-NET-Bootcamp/aw4-BekirK-C/assets/80921292/c23370d8-1346-4a73-ae8d-a99e5b8d0605)

- Data>Repository>CategoryDapper içerisinde category modeli için bir Generic yapıdan inherit alan bir sınıftır

![image](https://github.com/P259-Simpra-NET-Bootcamp/aw4-BekirK-C/assets/80921292/03026488-3352-4c44-875e-d854b14df559)

- Operation>Dapper>Category içerisinde Category modeli için DapperCategoryService adından iş kodları yazıldı.

![image](https://github.com/P259-Simpra-NET-Bootcamp/aw4-BekirK-C/assets/80921292/69061535-3261-4995-8832-e71f440c37a7)

- Service>Category içerisinde DapperCategoriesController sınıfı içerisinde iş kodları çağrılarak controller sınıfı oluşturuldu.

![image](https://github.com/P259-Simpra-NET-Bootcamp/aw4-BekirK-C/assets/80921292/00a253fd-8fa2-4d94-8132-a3f5540eeecd)

- Service>Autofac içerisinde DependencyResolver sınıfında tüm DI işlemleri için bir module eklenerek startup içerisinde bu module çağrıldı.

![image](https://github.com/P259-Simpra-NET-Bootcamp/aw4-BekirK-C/assets/80921292/f2fea9f1-b9e1-4fe4-bf6f-213f46b993b8)

- TransactionReportController'ı EF ile çalştırmak için Data>Repository>Transaction içerisinde Generic repository'den kalıtım alan EfTransactionRepository sınıfı oluşturuldu.

![image](https://github.com/P259-Simpra-NET-Bootcamp/aw4-BekirK-C/assets/80921292/ce6b0746-8d08-4dc8-b056-df2e06a5a30a)

Ardından Operation>Dapper TransactionReportService sınıfında EfTransactionRepository'i kullanarak içerisindeki metotları Ef ile kodladım. 

![image](https://github.com/P259-Simpra-NET-Bootcamp/aw4-BekirK-C/assets/80921292/99d0a9bb-6b4a-4a0a-adfe-ef1e5d140265)
