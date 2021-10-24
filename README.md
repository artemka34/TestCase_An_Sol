1. Необходимый софт (необходимо докачать/убедиться, что работает):
	- .NET Core SDK 3.1
	- EntityFramework
	- SQL Server Express 2019
2. Решение разделено на две архитектурные части:
	- Веб-приложение (Angular front + .NET back)
	- Микросервис для работы с БД (к API есть документаия в swagger, можно получить по localhost:5002/swagger)
3. Запуск приложения:
	- Необходимо создать БД в локальном SQL Server: выполняем в корневой папке команду:
		dotnet ef database update -p Repository -s API
	- Если всё успешно, то запускаем проект API. Он должен запуститься на localhost:5002
	- Запускаем WebConfigurationApplication. Откроется на localhost:5000/5001
	- Наслаждаемся приложением.

PS Стилей нет, но вы держитесь

	
