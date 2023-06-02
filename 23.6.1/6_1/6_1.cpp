#include<stdio.h>

//int main() // 입력 부분과 출력 부분의 구분 
//{
//	// { 변수 선언부
//	int result;
//	int num1, num2;
//	// } 변수 선언부
//
//
//	// { 사용자 입력 받는 로직
//	printf("정수 one : ");
//	scanf_s("%d", &num1);
//	printf("정수 two : ");
//	scanf_s("%d", &num2);
//	// } 사용자 입력 받는 로직
//
//
//
//	// 위의 로직을 한 개씩으로 줄여볼 수 있다
//	printf("정수 2개를 입력해 주세요 : ");
//	scanf_s("%d, %d", &num1, &num2);
//	
//
//
//
//	// { 실제 연산하는 로직 / 플러스 연산
//	result = num1 + num2;
//	printf("%d + %d = %d \n", num1, num2, result);
//	return 0;
//    // } 실제 연산하는 로직 / 플러스 연산
//
//
//} // main()  함수의 끝을 적어주는 것이 좋다!




//int main()
//{
//	// 변수 선언
//	int num1, num2, num3;
//	int result;
//
//	// 입력 요청
//	printf("숫자 3개를 입력해주세요. ex 3, 4, 5 \n");
//	scanf_s("%d, %d, %d", &num1, &num2, &num3);
//
//	// 출력
//	result = num1 + num2 * num3;
//	printf("%d + %d * %d = %d \n", num1, num2, num3, result);
//	return 0;
//
//}



//int main()
//{   
//	// 변수의 선언
//	int num1, num2, num3;
//    int result1, result2, result3;
//	int result4;
//
//	// 입력 요청
//	printf("숫자 3개를 입력해주세요. ex 3, 4, 5 \n");
//	scanf_s("%d, %d, %d", &num1, &num2, &num3);
//
//	// 각 사칙연산 부분을 Result 값으로 정의, 변수의 값이 입력 부분에서 들어온 다음에 Result 값을 구할 수 있음 -> 입력 부분 아래로 내려야함
//	result1 = (num1 - num2);
//	result2 = (num2 + num3);
//	result3 = (num3 % num1);
//	result4 = result1 * result2 * result3;
//
//	// 추가작성, 이런 방식도 맞음
//	// result = (num1 - num2) * (num2 + num3) * (num3 % num1);
//
//	// 출력
//	printf("%d \n", result4);
//	return 0;
//}


//int main ()
//{
//	//// 정수형 데이터 타입들
//	//char charvalue = 'A';                     // 문자 하나를 저장하기 위한 데이터 타입
//	//short shortvalue = 10;                    // int 보다 작은 수를 저장하기 위한 데이터 타입 (3만2천개의 수)
//	//int intvalue = 100;                       // 가장 만만한 수를 저장하기 위한 데이터 타입 
//	//long longvalue = 200;                     // int가 커져서 이제 잘 안쓰는 데이터 타입
//	//long long longLongvalue = 1000;           // int보다 큰 수를 저장하기 위한 데이터 타입
//
//
//	//// 실수형 데이터 타입들
//	//float floatvalue = 10.1;                  // 가장 만만한 실수를 저장하기 위한 데이터 타입
//	//double doublevalue = 100.1;               // float 보다 큰 실수를 저장하기 위한 데이터 타입
//	//long double longdoublevalue = 200.1;      // double 보다 큰 실수를 저장하기 위한 데이터 타입
//
//	//
//	//printf("char 의 크기는? %d btye \n", sizeof(charvalue));
//	//printf("short 의 크기는? %d byte \n", sizeof(shortvalue));
//	//printf("int 의 크기는? %d byte \n", sizeof(intvalue));
//	//printf("long 의 크기는? %d byte \n", sizeof(longvalue));
//	//printf("long long 의 크기는? %d byte \n", sizeof(longLongvalue));
//
//	//printf("float 의 크기는? %d byte \n", sizeof(floatvalue));
//	//printf("double 의 크기는? %d byte \n", sizeof(doublevalue));
//	//printf("long double 의 크기는? %d byte \n", sizeof(longdoublevalue));
//
//
//	//const float PI = 3.141592f;
//
//
//
//	return 0;
//
//}



//
//    // 함수의 전방선언 - 함수의 이름과 () 안에 들어갈 변수도 작성
//float circlespace(float PI, int radius);
//
//
//int main()
//{   
//	const float PI = 3.141592f;                      // 상수 PI를 선언
//    int radius;                                    // 변수 반지름 선언
//	
//	// 입력 요청
//	printf("원의 반지름을 입력하세요:");             // 입력 요청 출력
//	scanf_s("%d", &radius);                          // 반지름 입력값 스캔, 반지름 변수 앞에 &
//
//	
//	// 출력                                          // 출력문 > 소켓 2개 (%d와 %.3f)에 각각 변수 radius와 계산함수 ciclespace(변수포함)를 넣는다
//	printf("입력하신 원의 반지름은 %d입니다. 요청하신 원의 넓이는 %.3f입니다.", radius, circlespace(PI, radius));
//
//	return 0;
//}
//
//	// 계산식 함수
//float circlespace(float PI, int radius)            // 계산함수 circlespace 정의 () 안에 변수 넣기
//{
//	float result;
//	result = PI * radius * radius;                   // 계산식을 return이라는 값으로 돌려줌
//	return result;
//}







//	const float PI = 3.141592f;
//    int radius;
//
//	void RadiusCal(int radius1, float PI);
//
//
//int main()
//{
//	
//	printf("원의 반지름을 입력하세요:");
//	scanf_s("%d", &radius);
//
//	void RadiusCal();
//
//	return 0;
//
//
//}
//
//
//void RadiusCal(int radius1, float PI)
//{
//	float result;
//
//	result = PI * radius1 * radius1;
//	printf("입력하신 반지름 값은 %d 입니다. 원의 넓이는 %.3f", radius1, result);
//
//}






//                                             // 아스키 코드 판정
//int main()                                                         
//{
//	char charvalue = 'b';
//	printf("char 출력할 때는 c로 해보자. -> %c \n", charvalue);
//
//	bool issame = ('a' == 65);
//	printf("\n진짜로 같은가?? %d \n", issame);
//
//	bool isbigalphabet = ('a' <= somealphabet && somealphabet <= 'z');
//	printf("\nsomealphabet은 대문자인가?? %d \n", isbigalphabet);
//
//	return 0;
//
//}






//
//void check(char alphabet1);                       // 연습
//int main()
//{
//	char alphabet;
//	printf("문자를 하나 입력하세요 : ");
//	scanf_s("%c", &alphabet);
//	check(alphabet);
//	
//	printf("");
//
//	return 0;
//}
//void check(char alphabet1)
//{
//	printf("%d\n", alphabet1);
//	printf("%c는 %s", alphabet1,(65 <= alphabet1 && alphabet1 <= 90) ? "대문자입니다." : (97 <= alphabet1 && alphabet1 <= 122) ? "소문자입니다." : "특수문자입니다.");
//}
//


//
//void Check(char);									// 선언 -> 다만 함수 안에 자료형을 명시해야함
//
//int main()
//{	
//	char alphabet;									// 메인함수 안에서 변수 선언
//	printf("문자를 하나 입력하세요 : ");				
//	scanf_s("%c", &alphabet);						// 출력 및 스캔
//	Check(alphabet);								// 함수 호출
//
//	return 0;
//
//}
//
//void Check(char alphabet)							// 아래서 정의한 함수, 안에는 변수의 자료형과 변수 이름까지 모두 적는다
//{
//	('A' <= alphabet && alphabet <= 'Z') ? printf("입력값은 대문자입니다.") :
//	('a' <= alphabet && alphabet <= 'z') ? printf("입력값은 소문자입니다.") :
//	('!' <= alphabet && alphabet <= '/') || (':' <= alphabet && alphabet <= '@') || 
//	('[' <= alphabet && alphabet <= '`') || ('{' <= alphabet && alphabet <= '~') ? printf("입력값은 특수문자입니다.") : printf("입력값은 숫자입니다.");
//}													// 삼항연산자 사용, 논리문 사용
//													// 문자 또한 숫자로 인식하므로 문자열에 ''로 범위 지정
//													// 조건 ? 출력값1 : 출력값2 의 형태
//													// 출력값에 printf 쓰면 바로 나옴
//


//
//int main()
//{
//	if(isbigalphabet)
//	{
//		printf("영문 대문자 입니다. \n");
//									  if문은 조건식이 참이면 스코프 안의 내용을 진행하고, 거짓이면 건너뛴다.	
//	}
//
//	else if(issmallalphabet)
//	{
//		printf("영문 소문자 입니다. \n");
//									 if와 else 사이에 else if로 추가 조건을 걸어줄 수 있다.
//	}
//
//	else if(isnumber)
//	{
//		printf("숫자 입니다. \n");
//		
//	}
//
//	else
//	{
//		printf("영문 대문자가 아닙니다. \n");
//									  위의 조건식에서 참이 아닌, 다른 모든 경우 스코프 안의 내용을 진행한다.
//	}
//}			
//


//
//int main()
//{
//	int loopCount = 5;													// 루프의 횟수 설정, 변수 선언
//
//	while (1 <= loopCount)												
//	{
//		printf("Hello world! 몇 번째 돌고 있는지? %d \n", loopCount);
//		loopCount -= 1;													// -=로 연산때마다 카운트가 줄어든다.
//																		// 카운트가 0이 되면 while문에서 빠져 나온다.
//
//	}
//	return 0;
//}
//




//int main()
//{
//	int loopCount = 1;
//
//	while (10 >= loopCount)												// 조건이 거짓이면 바로 나가짐                                      
//	{
//		printf("현재 숫자는 %d \n", loopCount);
//		loopCount += 1;
//	}
//	return 0;
//}



int main()
{
	int loopCount;

	scanf_s("%d", &loopCount);


	while (loopCount)
	{
		while (loopCount)
		{
			printf("* ");
			loopCount -= 1;
		}
		printf("\n");
		loopCount += 1;

	}
}


