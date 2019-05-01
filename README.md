- [x] Создайте четыре метода для выполнения арифметических операций, с именами: Add – сложение, Sub – вычитание, Mul – умножение, Div – деление. Каждый метод должен принимать два целочисленных аргумента и выводить на экран результат выполнения арифметической операции соответствующей имени метода. Метод деления Div, должен выполнять проверку попытки деления на ноль.  
Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак арифметической операции, для выполнения вычислений. 

- [x] Напишите программу, которая будет выполнять конвертирование валют.
Пользователь вводит:
сумму денег в определенной валюте.
курс для конвертации в другую валюту.
Организуйте вывод результата операции конвертирования валюты на экран.

- [x] Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли клиент кредит или нет. Допустим, ежемесячная сумма платежа должна составлять 100 грн. Клиент должен выполнить 7 платежей, но может платить реже большими суммами. Т.е., может двумя платежами по 300 и 400 грн. Закрыть весь долг.
Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную экономистом банка. Метод выводит на экран информацию о состоянии кредита (сумма задолженности, сумма переплаты, сообщение об отсутствии долга).

- [ ] ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
	If the function is passed a valid PIN string, return true, else return false.

	eg:

	ValidatePin("1234") => true
	ValidatePin("12345") => false
	ValidatePin("a234") => false


- [ ] Given the triangle of consecutive odd numbers:
```
				1
			3   	  5
		7   	  9  	  11
	13  	  15  	 17	    19
21   	 23  	  25  	 27  	 	 29
```
Calculate the row sums of this triangle from the row index (starting at index 1) e.g.:

	RowSumOddNumbers(1); // 1
	RowSumOddNumbers(2); // 3 + 5 = 8


- [ ] Take 2 strings s1 and s2 including only letters from ato z. Return a new sorted string, the longest possible, containing
	distinct letters,
	each taken only once - coming from s1 or s2.

	Examples:

	a = "xyaabbbccccdefww"
	b = "xxxxyyyyabklmopq"
	Longest(a, b) -> "abcdefklmopqwxy"

	a = "abcdefghijklmnopqrstuvwxyz"
	Longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"

- [ ] Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the
	output should be capitalized only if the original word was capitalized.

	Examples:
	Kata.ToCamelCase("the-stealth-warrior") 
	// returns "theStealthWarrior"

	Kata.ToCamelCase("The_Stealth_Warrior") 
	// returns "TheStealthWarrior"



