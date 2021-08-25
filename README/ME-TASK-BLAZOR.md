# Blazor App
[#Code](me-task-blazor/)

Blazor app created for test task. For resolve all score in project used BlazorWebAssembly project with N-Tier architecture implementation.<br>

![alt text](https://www.google.com/url?sa=i&url=https%3A%2F%2Fmarketplace.visualstudio.com%2Fitems%3FitemName%3DChristofSenn.N-TierEntityFrameworkVS2015&psig=AOvVaw3rxlq9bZGDAA_w8JxQ3nAL&ust=1629909585683000&source=images&cd=vfe&ved=0CAoQjRxqFwoTCKDl982EzfICFQAAAAAdAAAAABAI)

# me-task-blazor.Client
Blazor.Client prodeces presentation layer of app architecture. Еhe main task of the Сlient is to render the data that he receives from the server. 


# me-task-blazor.Server
With the Blazor Server hosting model, the app is executed on the server from within an ASP.NET Core app.
In this project server use EntityFramework to produce dbContext. EntityFramework create connection with setup database and works like database middleware.

All requests to models are implemented through api requests. Api have [swagger documentation](docs/api-doc.json).
