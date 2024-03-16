### V2'de Neler Yapıldı?
+ WindowsFormApp ile basit bir görsel arayüz yapıldı.

+ Projeye veri tabanı eklendi(MSSQL)

+ Veri tabanında GetAll(),Add(),Update(),Delete() opersayonları için Entity Framework kullanıldı.
#

#### ÖNEMLİ
Bu projeyi çalıştırabilmek için ;
```
 <connectionStrings>
		<add
			name ="KodlamaIOContext"
			connectionString="YOUR_CONNECTION_STRING"
			 providerName="System.Data.SqlClient" />
	</connectionStrings>
```
bu kodda YOUR_CONNECTION_STRING kısmına kendi connectionString'inizi yazmayı unutmayın.
#
