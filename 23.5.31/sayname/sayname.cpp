#include<stdio.h>

//int Name(int number)
//{
//	return number;
//}

//void PrintFunc(int age)
//{
//	printf("이대연, 나이: %d, 010-9063", age);
//}


//int Spec(int number)
//{
//	return number;
//}
//
//float Dam(float number1)
//{
//	printf("%f", number1);
//	return number1 * 1.5;
//}

//float main()
//{
//	printf("이름: 심준보\n");
//	printf("나이: %d세\n", Name(33));
//	printf("번호: 010-7355-7069\n");
//
//	PrintFunc(50);
//
//
//	printf("CPU: i5 12400\n");
//	printf("RAM: %d GB\n", Spec(32));
//	printf("GPU: RTX 3060\n");
//
//
//	printf("플레이어는 %f 데미지를 입혔다!\n", Dam(100));
//
//
//}
//


//float Rate(int number)
//{
//	printf("%d", number);
//	return number + number * 0.2;
//
//}


//int main()
//{
//	printf("다음달 계좌 잔액은 %f 입니다.", rate(10));
//
//    int num1 = 9, num2 = 2;
//
//	printf("%d + %d = %d\n", num1, num2, num1 + num2);
//	printf("%d - %d = %d\n", num1, num2, num1 - num2);
//	printf("%d * %d = %d\n", num1, num2, num1 * num2);
//	printf("%d / %d = %d\n", num1, num2, num1 / num2);
//	printf("%d %% %d = %d\n", num1, num2, num1 % num2);
//
//
//
//}

int Plus(int num1, int num2)
{
	printf("%d + %d\n", num1, num2);
	return num1 + num2;
}

int Minus(int num1, int num2)
{
	printf("%d - %d\n", num1, num2);
	return num1 - num2;
}

int Multiple(int num1, int num2)
{
	printf("%d * %d\n", num1, num2);
	return num1 * num2;
}

int Divide(int num1, int num2)
{
	printf("%d / %d\n", num1, num2);
	return num1 / num2;
}

int Mod(int num1, int num2)
{
	printf("%d %% %d\n", num1, num2);
	return num1 % num2;
}






int main()
{

	printf("%d, %d, %d, %d, %d\n", Plus(14, 8), Minus(14, 8), Multiple(14, 8), Divide(14 ,8), Mod(14, 8));






	//int num1 = 9, num2 = 2;
	//int result1 = 0;
	//result1 = result1 + (num1 + num2);
	//result1 += (num1 + num2);


	////num1++;
	//printf("num1: %d\n", num1);

	////++num;
	//printf("num1: %d\n", num1);


	//int somenumber = 0;
	//somenumber = somenumber++;
	//printf("some number 안에는 무슨 값이 들어 있을까? %d \n", somenumber);



	int num1 = 10;
	int num2 = 12;
	int result1, result2, result3;

	result1 = num1 == num2;
	result2 = num1 <= num2;
	result3 = num1 > num2;

	printf("Result1 결과는 %d\n", result1);
	printf("Result2 결과는 %d\n", result2);
	printf("Result3 결과는 %d\n", result3);




	int num1 = 10;   // float num1 = 1.3 , int num1 = -3 도 가능
	int num2 = 12;
	int result1, result2, result3;

	result1 = (num1 == 10 && num2 == 12);
	result2 = (num1 < 12 || num2 > 12);
	result3 = (!num1); // 0이 아닌 모든 수가 참

	printf("result1: %d \n", result1) :
	printf("result2: %d \n", result2) :
	printf("result3: %d \n", result3) :






	int age = 15;
	bool boolResult;

	boolResult = (age < 20) ? true : false;
	printf("Bool result는 어떤 값? %d", boolRsesult);




	//void PrintFunc(int age); //main 함수보다 먼저 내가 만든 함수가 이런 모양이다라고 알려주는 역할

	//int main()
	//{
	//	PrintFunc

	//}


	printf("숫자 값을 입력해주세요 -> ");

	int inputnumber = 0;
	scanf_s("%d", &inputnumber);
	printf("Input number의 값은? %d \n", inputnumber);










	//int num1 = 14;
	//int num2 = 6;

	//printf("%d + %d = %d\n", num1, num2, num1 + num2);
	//printf("%d - %d = %d\n", num1, num2, num1 - num2);
	//printf("%d * %d = %d\n", num1, num2, num1 * num2);
	//printf("%d / %d = %d\n", num1, num2, num1 / num2);
	//printf("%d %% %d = %d\n", num1, num2, num1 % num2);

	
}
