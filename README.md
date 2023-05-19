Bu proje, katmanlı mimari tasarımını kullanan bir .NET Core projesidir. Proje henüz tamamlanmamıştır ve veritabanı bağlantısı ve bazı işlevler konusunda hatalar ve eksikler bulunmaktadır.

#Proje Yapısı
Proje 4 katmana ayrılmıştır:

StaffManagement.DataAccess: Veri depolama ve almayı yönetir.
StaffManagement.BusinessLogic: Operasyonel hizmetleri içerir.
StaffManagement.Schema: Veri şemalarını tanımlar.
StaffManagement.API: Web hizmeti yapılandırmasını ve denetleyicilerini içerir.

shell
Kodu Kopyala
dotnet run --project SimApi.Service/SimApi.Service.csproj