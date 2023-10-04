Use TechSolutions

Create table PaymentCard(
	Id int IDENTITY(1,1) not null Primary key,
	CardNumber nvarchar(16) not null,
	Cvc int not null,
	CardExpiryDate varchar(5) not null,
	BillingAddress nvarchar(50) not null
); 



CREATE Table Customer(
	
	CustomerId INT  IDENTITY(1,1) NOT NULL PRIMARY KEY,
	CustomerName nvarchar(100) not null,
    Email nvarchar(100) not null,
	Phone nvarchar(100) not null,
	PaymentCardId int FOREIGN KEY REFERENCES PaymentCard(Id)
	);