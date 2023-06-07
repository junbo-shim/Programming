#include<iostream>
#include<time.h>
#include<windows.h>
#include<stdlib.h>

void Des001();
void Des002();
void Des003();
void Des004();
void Des005();
void Des006();
void Des007();

int LargeAlpha();
int SmallAlpha();
void Swap(char firstChar, char secondChar);
void Swap2(char* firstChar, char* secondChar);
void ShuffleOnce(int* firstNumber, int* secondNumber);


int main ()
{
	Des007();

	return 0;
}


//void Des001()															// 배열
//{
//	char string_[15] = { 0, };
//	string_ = "Good morning!\n";										// 문자형 배열의 선언, 초기화 방법
//
//	char string_[15] = "Good morning!\n";								// 보통의 문자열 선언 방식
//	char string2[] = "Good morning!\n";									// [] 안을 비우면 글자+1의 수가 자동으로 배열 크기로 할당됨
//
//
//	int numbers[10] = { 0, };
//
//
//	printf("%s", string_);
//	printf("%d", sizeof(string_));
//
//	printf("문자열 배열의 크기 %d\n", sizeof(string_));
//	printf("정수형 배열의 크기 %d\n", Sizeof(numbers));
//	printf("정수형 배열의 길이 %d\n", sizeof(sizeof(numbers) / sizeof(int));
//	
//
//
//
//	bool isNullSameZero = false;										// NULL 의 존재여부와 0과 동일한지에 대한 판정
//	if(0 == '\0')
//	{
//		isNullSameZero = true;
//	}
//	else
//	{
//		is NullSameZero = false;
//	}
//
//	printf("Null은 0과 같은 값인가? : [%d] \n", isNullSameZero);
//
//
//
//	char string3[4];													// NULL 문자열의 끝을 알려주는 역할
//	string3[0] = 'H';													// 문자열을 하나씩 넣을 경우 NULL이 빠지면 오류발생
//	string3[1] = 'i';
//	string3[2] = '!';
//	string3[3] = '\0';													// 직접 NULL을 집어넣어도 컴파일러에서 정상적으로 출력됨
//																		
//	char string4[4] = "Hi!";											// 자동으로 NULL이 들어간 상태
//
//
//	printf("string4번 찍어보겠음 -> %s \n", string4)
//	printf("string3번 찍어보겠음 -> %s \n", string3)
//}

//void Des002()															// 유저한테 문자열을 입력받은 것을 출력할때
//{
//	char str[300] = { 0, };
//	printf("문자열을 입력하시오(200자 이내로) : ");
//	std::cin >> str;													// 유저입력 스캔 명령어
//
//	printf("제대로 입력을 받았는지? -> %s", str);							// 입력을 출력
//}


void Des003()															// 실습(대문자-소문자-대문자-소문자 순으로 출력하는 프로그램)
{
	char str[400] = { 0, };												// 400개의 서랍칸
	int a = 0;															// 서랍칸번호의 존재 선언

	printf("입력하세요(300자 이내)\n : ");
	std::cin >> str;

	for (a = 0; a < 400; a++)											// 서랍칸번호 조건문 루프 : 0번부터 399번부터 돌면서 데이터를 저장
	{

		if (str[a] == 0)												// 서랍칸 값이 0일 경우 루프를 탈출하는 조건문
		{																// 배열안의 값이 0으로 초기화 되었으므로 루프 앞부분에서 적어야 함 
			str[a] = '\0';												
			break;
		}

		if (a % 2 == 0)													// 서랍칸번호 짝수일때, str[a]는 홀수번째, 즉 대문자
		{
			if (65 <= str[a] && str[a] <= 90)
			{
				str[a] = str[a];
			}
			else
			{
				str[a] = str[a] - 32;
			}
		}
		else if (a % 2 == 1)											// 서랍칸번호 홀수일때, str[a]는 짝수번째, 즉 소문자
		{
			if (97 <= str[a] && str[a] <= 122)
			{
				str[a] = str[a];
			}
			else
			{
				str[a] = str[a] + 32;
			}
		}
	}
	printf("출력 : %s", str);
}


void Des004()															// 실습(Des003을 거꾸로 뒤집어 출력하는 프로그램)
{
	char str[300] = { 0, };												// 400개의 서랍칸
	char str2[300] = { 0, };
	int a = 0;															// 서랍칸번호의 존재 선언
	int size_str = 0;
	printf("입력하세요(200자 이내)\n : ");
	std::cin >> str;

	for (a = 0; a < 300; a++)											// 서랍칸번호 조건문 루프 : 0번부터 399번부터 돌면서 데이터를 저장
	{
		size_str = a;													// 배열의 크기를 알려면 루프를 몇번 도는지 알아야함
		
		
		if (str[a] == 0)												// 서랍칸 값이 0일 경우 루프를 탈출하는 조건문
		{																// 배열안의 값이 0으로 초기화 되었으므로 루프 앞부분에서 적어야 함 
			str[a] = '\0';												
			break;
		}

		if (a % 2 == 0)													// 서랍칸번호 짝수일때, str[a]는 홀수번째, 즉 대문자
		{
			if (65 <= str[a] && str[a] <= 90)
			{
				str[a] = str[a];
			}
			else
			{
				str[a] = str[a] - 32;
			}
		}
		else if (a % 2 == 1)											// 서랍칸번호 홀수일때, str[a]는 짝수번째, 즉 소문자
		{
			if (97 <= str[a] && str[a] <= 122)
			{
				str[a] = str[a];
			}
			else
			{
				str[a] = str[a] + 32;
			}
		}		

	}

	size_str -= 1;														// 배열의 크기는 루프 값 -1
	
	
	for(a=size_str; a>=0; a--)
	{	
		str2[a] = str[size_str-a];										// [] 안의 값을 a로 표현해야함
																		// a = size-a

		//str2[10] = str[10 - 10];
		//str2[9] = str[10 - 9];
		//str2[8] = str[10 - 8];
		//str2[7] = str[10 - 7];
		//str2[6] = str[10 - 6];
		//str2[5] = str[10 - 5];
		//str2[4] = str[10 - 4];
	}
	printf("출력 : %s", str2);
}


//void Des005()
//{
//	char str[10] = "Hello";
//	char temp = '\0';
//
//	str[0] = str[4];
//	str[4] = str[0];
//
//	printf("str의 0번째 값 : %c , strㅇ,; 4번째 값 : %c \n", str[0], str[4]);				// 출력값은 둘 다 o, o
//
//	
//	temp = str[0];																		// temp 라는 변수로 중간에서 값을 받아줘야함
//	str[0] = str[4];
//	str[4] = temp;
//	
//
//	Swap(str[0], str[4]);
//	Swap2(&str[0], &str[4]);
//
//	printf("%s \n", str);
//
//}


//void Swap2(char* firstChar, char* secondChar)																		// 스왑 함수를 사용하려면 포인터로 주소를 전달해야 한다
//{
//	printf("[스왑 이전] fisrtChar 값 : %c, secondChar 값 : %c \n", fisrtChar, secondChar);
//	char temp = '\0';
//
//	temp = (*firstChar);
//	(*firstChar) = (*SecondChar);
//	(*SecondChar) = temp;
//
//	printf("[스왑 이후] fisrtChar 값 : %c, secondChar 값 : %c \n", fisrtChar, secondChar);
//}


//void Swap (char firstChar, char secondChar)																			// 스왑을 해도 지역변수 때문에 값이 안에서 바뀌고 끝남
//{	
//	printf("[스왑 이전] fisrtChar 값 : %c, secondChar 값 : %c \n", fisrtChar, secondChar);
//	char temp = '\0';
//
//	temp = firstChar;
//	firstChar = SecondChar;
//	SecondChar = temp;
//
//	printf("[스왑 이후] fisrtChar 값 : %c, secondChar 값 : %c \n", fisrtChar, secondChar);
//}


//void Des006()																										// 포인터 설명
//{
//	int number = 100;
//	int* ptrnumber = &number;
//
//	printf("number 변수의 줏소는 : %p, 할당된 값은 %d \n", &number, number);											// number의 주소와 값
//	printf("ptrNumber 변수의 주소는 %p, 할당된 값은 %p, 역참조한 값 : %d \n", &ptrNumber, ptrNumber, *ptrNumber);			// ptrNumber의 주소, number의 주소, number 값
//
//}


//void Des007()																										// 셔플 설명
//{
//
//	int numbers[10] = { 0, };			// 배열의 선언과 초기화
//	for(int i=0; i<10; i++)
//	{
//		numbers[i] = i + 1;
//	}									// 배열의 선언과 초기화 끝
//
//	printf("Shuffle 하기 전\n\n");		// 셔플 하기 전 배열의 출력
//	for(int i=0; i<10; i++)				
//	{
//		printf("%d ", numbers[i]);
//	}
//	printf("\n\n");						// 셔플 하기 전 배열의 출력 끝
//
//
//										// 셔플 로직
//	const int shuffleCount = 200;
//	int randomIdx1, randomIdx2 = 0;
//	srand(time(NULL));
//
//	// int randomIdx1, randomIdx2 = 0;
//
//	for (int i = 0; i < shuffleCount; i++)							// 상수 값 셔플 카운트를 만들고 for 문에서 횟수만큼 돌리는 방법
//	{
//		randomIdx1 = rand() % 10;
//		randomIdx2 = rand() % 10;
//		ShuffleOnce(&numbers[randomIdx1], &numbers[randomIdx2]);
//	}
//	
//	printf("\n");						// 셔플 로직 끝
//	
//
//	printf("Shuffle 한 후\n\n");			// 셔플한 후 출력
//	for (int i = 0; i < 10; i++)		
//	{
//		printf("%d ", numbers[i]);
//	}
//	printf("\n\n");						// 셔플한 후 출력 끝
//
//
//}

void ShuffleOnce(int* firstNumber, int* secondNumber)					// 셔플 함수
{
	int temp = 0;
	temp = *firstNumber;
	*firstNumber = *secondNumber;
	*secondNumber = temp;
}


void Des007()																// 셔플 설명
{

	int numbers[45] = { 0, };												// 배열의 선언과 초기화
	for(int i=0; i<45; i++)
	{
		numbers[i] = i + 1;
	}																		// 배열의 선언과 초기화 끝

	//printf("Shuffle 하기 전\n\n");											// 셔플 하기 전 배열의 출력
	//for(int i=0; i<6; i++)				
	//{
	//	printf("%d ", numbers[i]);
	//}
	//printf("\n\n");														// 셔플 하기 전 배열의 출력 끝


												// 셔플 로직
	const int shuffleCount = 30000;
	int randomIdx1, randomIdx2 = 0;
	srand(time(NULL));

	// int randomIdx1, randomIdx2 = 0;

	for (int i = 0; i < shuffleCount; i++)							// 상수 값 셔플 카운트를 만들고 for 문에서 횟수만큼 돌리는 방법
	{
		randomIdx1 = rand() % 45;									// % 값에 따라 0 ~ % 까지 숫자가 랜덤하게 나옴 -> 10으로 걸면 0 ~ 9까지 나옴
		randomIdx2 = rand() % 45;
		ShuffleOnce(&numbers[randomIdx1], &numbers[randomIdx2]);
	}
	
	printf("\n");								// 셔플 로직 끝
	

	printf("Shuffle 한 후\n\n");					// 셔플한 후 출력
	for (int i = 0; i < 6; i++)					// 6개까지만 출력 할 것이므로 6으로 변경
	{
		printf("%d ", numbers[i]);
		Sleep(1000);
	}
	printf("\n\n");								// 셔플한 후 출력 끝


}