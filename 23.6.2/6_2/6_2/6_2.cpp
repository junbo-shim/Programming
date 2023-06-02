#include<stdio.h>
#include<stdlib.h>
#include<time.h>
//
//
//int main()					// continue의 사용방법 - 7번째 멘트만 제외하고 출력
//{
//	int loopCount = 1;
//	while (loopCount <= 10)
//	{	
//		if(loopCount == 7) 
//		{	
//			loopCount += 1;
//			continue; 
//		}
//		printf("이것은 무조건 출력되는 문장인가? loopCount: %d \n", loopCount);
//		loopCount += 1;
//	}
//
//	return 0;
//}
//
//
//
//
//
//int main()					// break의 사용방법 - 7번째 이후로 모두 제외
//{
//	int loopCount = 1;
//	while (loopCount <= 10)
//	{
//	if(loopCount == 7)
//	{
//		loopCount += 1;
//		break;
//	}
//	printf("이것은 무조건 출력되는 문장인가? loopCount: %d \n", loopCount);
//	loopCount += 1;
//	}
//
//	return 0;
//}
//
//
// 
// 
// 
//
//
//
//int main()
//{
//	char userInput = 'A';			// 아스키 코드 활용시에는 무조건 ' ' 안에 글자를 넣어야함
//	int loopCount = 1;
//	
//	while ('A' <= userInput <= 'Z') // 무조건 참의 오류 A가 항상 A보다 같거나 크므로 1 상태 그대로임. 올바른 조건식 -> ('A' <= userInput && userInput <= 'Z')
//	{
//		if (loopCount == 1)
//		{
//			printf("[튜토리얼] 만약 게임을 만들려고 한다면 이런식으로 \n\n");
//
//
//			printf("[system] 당신은 플레이어 입니다. \n");
//
//			printf("수행할 액션을 입력해 주세요. : ");
//			scanf_s("%c", &userInput);
//
//			if (userInput == 'q' || userInput == 'Q')
//			{
//				printf("\n[system] 프로그램을 종료합니다. \n");
//				break;
//			}
//			else
//			{
//				printf("\n[system] 해당 입력은 정의되어 있지 않습니다. \n");
//				loopCount += 1;
//				continue;
//			}
//		}
//	}
//}








//
//int main()
//{
//	int number = 0;															//number 라는 변수 선언
//	char number2;														//number2 문자 변수 입력??
//
//
//	while(1)															//무한 루프를 위해서 while문 조건을 1로 설정		
//	{
//			printf("\n [system] 숫자만 입력해주세요. \n");					//입력 요청
//			scanf_s("%d", &number);
//			scanf_s("%c", &number2);
//			if (number2<0)                                                 //혹시 모르니 else문도 설정 (다만 숫자는 위에서 알아서 처리하므로 거의 쓸모 없음)
//			{
//				printf("\n %c는 문자입니다.\n", number2);
//				continue;
//			}
//
//
//
//			if (number % 2 == 1 || -number % 2 == 1)							//if문 조건 설정 -> number 변수를 2로 나눈 나머지가 1일 경우 홀수
//			{																//음수값도 생각하려면 -number를 or로 추가
//				printf("\n 입력하신 숫자는 홀수 입니다.\n");
//
//			}
//			else if (number % 2 == 0 || -number % 2 == 0)					//else if문 조건 설정 -> number 변수를 2로 나눈 나머지가 0일 경우 짝수
//			{																//음수값 고려 -> -number or 
//				printf("\n 입력하신 숫자는 짝수 입니다.\n");
//
//			}
//	}
//}









//int main()
//{
//	Description002()
//	{
//	
//	
//	
//	}
//  int userInput; 
//  int loopCount;
//	while (loopCount <= 5)
//	{
//		printf("숫자를 입력하시오 : ");
//		scanf_s("%d", &userNumber);
//
//		if (userNumber <= 0)												//  탈출조건을 미리 위쪽에 작성해주어야 함
//		{
//			printf("\n프로그램을 종료합니다. \n");
//			return 0;
//		}
//
//		if (userNumber % 2 == 0)
//		{
//			printf("[%d]는 짝수 입니다. \n", userNumber);
//			loopCount += 1;
//			continue;
//		}
//
//		printf("[%d]는 홀수 입니다. \n", userNumber);
//		loopCounter += 1;
//	}
//	return 0;
//}








//int main()
//{
//
//	int userInput = 0;													// char userInput = '0';
//	printf("User input : ");											
//	scanf_s("%d", &userInput);											// userInput = _getch();  ->  _getch() 쓰려면 #include<conio.h>
//
//	switch (userInput)
//	{
//	case 1:																// case 'a' :
//		printf("이것은 1 \n");
//		break;
//	case 2:																// case 'b' :
//		printf("이것은 2 \n");
//		break;
//	case 3:																// case 'c' :
//		printf("이것은 3 \n");
//		break;
//	default:
//		printf("처리되지 않은 예외 입력입니다. \n");
//		break;
//	}
//
//	printf("프로그램을 종료합니다");
//																		// _getch();   -> 프로그램 종료를 한 턴 유예하는 것
//}







//
//int main()
//{
//	int number = 0;
//	printf("숫자를 입력해주세요. : ");
//	scanf_s("%d", &number);
//
//	switch (number % 2)
//	{
//		case 0:
//			printf("입력하신 %d는 짝수입니다. \n", number);
//			break;
//		case 1:
//			printf("입력하신 %d는 홀수입니다. \n", )
//
//	}
//
//
//
//}
//
//
//








//int main()
//{
//	printf("for 문은 반복문이다. 이렇게 돌아간다. \n");
//
//	for (int loopcount = 1; loopcount <= 5; loopcount += 1)					// for() 안에 '초기값, 조건식, 증감식'의 형태
//	{																		// 논리순서 -> 1초기값 / 2조건식 / 3함수내용 / 4증감식
//		printf("어떻게 돌아가고 있는 것이지??? \n");								//			5조건식 / 6함수내용 / 7증감식 ...
//	}																		// 초기값을 for문 전에 선언한다면 for()안의 초기값을 비워도 가능
//
//	printf("\n");
//}





//
//
//																			// 랜덤 이해하기
//																			// 랜덤함수 rand()는 #include<stdlib.h> 사용해야함
//int main()																	
//{
//	srand(time(NULL));														// 시드값을 변화시키는 함수
//																			// 시간함수 time()는 #include<time.h>를 사용해야함
//																			// srand(time(NULL)) -> 계속 변하는 시드값
//	int randomnumber1, randomnumber2, randomnumber3 = 0;
//	randomnumber1 = rand();
//	randomnumber2 = rand();
//	randomnumber3 = rand();
//	randomnumber4 = rand() % 11;											// 랜덤 출력 중에 0~10까지의 값만 받는 방법
//	randomnumber5 = (rand() % 6) + 1;										// 랜덤 출력 중에 1~6까지의 값만 받는 방법
//
//
//
//	printf("Random number?? %d \n", randomnumber1);
//	printf("Ramdom number?? %d \n", randomnumber2);
//	printf("Random number?? %d \n", randomnumber3);
//
//}



int diceA, diceB;
int dPlus;
int holljjaknum;
int playerinput;


int RollandPlus(int diceA, int diceB);
int Judge(int dPlus);
int playerJudge(int playerinput);
void Match(int playerinput, int holljjaknum);



int main()
{
	srand(time(NULL));

	diceA = (rand() % 6) + 1;
	diceB = (rand() % 6) + 1;

	dPlus = diceA + diceB;
	Judge(dPlus);

	
	printf("홀짝랜드에 오신 것을 환영합니다. \n주사위 2개의 합에 대한 홀짝을 맞춰보세요.");
	scanf_s("%d", &playerinput);


	playerJudge(playerinput);
	Match(playerinput, holljjaknum);


	return 0;
}

//int RollandPlus(diceA, diceB)
//{
//	srand(time(NULL));
//
//	diceA = (rand() % 6) + 1;
//	diceB = (rand() % 6) + 1;
//
//	dPlus = diceA + diceB;
//}

int Judge(int dPlus)
{
	switch (dPlus % 2) 
	{
		case 0 :
			holljjaknum = 0; //printf("컴퓨터의 주사위는 %d, %d 이므로 짝수입니다.", diceA, diceB);
			return 0;
		case 1 :
			holljjaknum = 1; //printf("컴퓨터의 주사위는 %d, %d 이므로 홀수입니다.", diceA, diceB);
			return 1;
	}
}

int playerJudge(int playerinput)
{
	switch (playerinput)
	{
		case 0 :
			playerinput = 0;
			return 0;
		case 1 :
			playerinput = 1;
			return 1;
	}


}

void Match(int playerinput, int holljjaknum)
{
	if(playerinput = holljjaknum && holljjaknum == 1)
	{
		printf("맞췄습니다! 컴퓨터의 주사위는 %d, %d 로 홀수입니다.", diceA, diceB);
	}
	else if(playerinput = holljjaknum && holljjaknum == 0)
	{
		printf("맞췄습니다! 컴퓨터의 주사위는 %d, %d 로 짝수입니다.", diceA, diceB);
	}
	else
	{
		printf("틀렸습니다 :( 컴퓨터의 주사위는 %d, %d 입니다.", diceA, diceB);
	}
}


