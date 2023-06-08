#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
#include<windows.h>
#include<time.h>

//
//void ArrayFunction(int* ptrArray);
//void ArrayFunction2(int myArray[], int arraySize);
//void Des001();

void Swap(int* first, int* second);
void ArraySort();
void ArraySort2();
void ArraySort3();

int main()
{
	ArraySort3();
	return 0;
}


//void Des001()
//{
//	int numbers[10] = { 0, };
//	for(int i=0; i<10; i++)
//	{
//		numbers[i] = (i + 1) * 10;
//	}
//	for(int i=0; i<10; i++)
//	{
//		printf("%d", numbers[i]);
//	}
//	printf("\n");
//
//	int* ptrNumber = &numbers[2];
//
//	printf("3번째 자리에 있는 값 +1 -> %d\n", (*ptrNumber) + 1);			// 포인터 역참조를 통해 저장된 값에 1을 더함
//	printf("3번째 자리에 있는 값 +1 -> %d\n", *(ptrNumber + 1));			// 주소값에 1을 더한 값을 불러오는 것 = 다음 주소의 값 출력
//
//
//	printf("numbers 가 들고 있는 값 -> %p \n", numbers);					// numbers의 값은 numbers[0]의 주소와 같다
//	printf("numbers[0]의 주소값 -> %p \n", &numbers[0]);
//
//
//
//	printf("numbers의 size : %d \n", sizeof(numbers));
//	ArrayFunction(numbers, 10);
//}

//void ArrayFunction2(int myArray[], int arraySize)
//{
//	printf("함수에서 찍어본 numbers의 size : %d \n", sizeof(myArray));
//
//	for(int i=0;i<sizeof(myArray)/sizeof(int); i++)
//	{
//		printf("array[%d]의 값 : %d \n", i, myArray[i]);
//	
//	}
//}
//
//void ArrayFunction(int* ptrArray, int arraySize)
//{	
//	printf("int 형 포인터의 자체적인 크기가 몇이지? -> %d \n", sizeof(ptrArray));
//	for (int i = 0; i < arraySize; i++)
//	{
//		printf("ptrArray 역참조 값 : %d \n", *(ptrArray));					// 배열을 포인터로 넘길 수 있다 -> 이때 넘기려는 배열의 크기를 정확하게 알아야만 메모리에서 범위를 안넘어갈 수 있다
//		printf("ptrArray +1 주소의 역참조 값 : %d \n", *(ptrArray + 1));
//	}																	// 중요한 것 : 포인터를 쓰기 위해서는 메모리에 값의 데이터 형식을 바탕으로 정확한 계산을 해야한다. 
//}


// 역참조 (배열의 5번째 값에 접근하려고 할 때)

// numbers[4];					// 이 형태가 배열을 사용한 역참조
// *(ptrNumber + 4);			// 이 형태가 포인터를 사용한 역참조
// *이 곧 [] 이다


void Swap(int* first, int* second)
{
	int temp = 0;
	temp = *first;
	*first = *second;
	*second = temp;
}

//void ArraySort()								// 숫자가 큰 순서로 배열하는 알고리즘 - 버블정렬(기준점없음 서로 비교 i, i+1)
//{
//	//int numbers[5] = { 21,59,36,99,17 };		// 배열의 정의-초기화
//	int numbers[5] = { 0, };
//	printf("숫자 5개를 입력하시오 : \n");
//	_getch();
//	scanf_s("%d %d %d %d %d", &numbers[0], &numbers[1], &numbers[2], &numbers[3], &numbers[4]);
//
//
//
//	for (int i=0; i < sizeof(numbers) / sizeof(int); i++)
//	{
//		printf(" %d /", numbers[i]);
//	}
//
//	for(int j=0; j< sizeof(numbers) / sizeof(int) - 1; j++)
//	{
//		for (int i = 0; i < sizeof(numbers) / sizeof(int) - 1; i++)
//		{
//			if (numbers[i] > numbers[i + 1])
//			{
//				Swap(&numbers[i], &numbers[i + 1]);
//			}
//			//else
//			//{
//			//	continue;
//			//}
//		}
//	}
//
//	for (int i=0; i < sizeof(numbers) / sizeof(int); i++)
//	{
//		printf(" %d /", numbers[i]);
//	}
//}
//
//
//void ArraySort2()								// 숫자가 큰 순서로 배열하는 알고리즘 - 선택정렬(기준점 존재 i기준으로 j돌리기 / 이후 i 증가)
//{
//	int numbers[5] = { 0, };
//	printf("숫자 5개를 입력하시오 : \n");
//	_getch();
//	scanf_s("%d %d %d %d %d", &numbers[0], &numbers[1], &numbers[2], &numbers[3], &numbers[4]);
//
//
//	for (int i=0; i < sizeof(numbers)/sizeof(int); i++)
//	{
//		for(int j=0; j < sizeof(numbers)/sizeof(int); j++ )
//		{
//			if(numbers[i] < numbers[j])
//			{
//				Swap(&numbers[i], &numbers[j]);
//			}
//		}
//	}
//
//
//	for (int i=0; i < sizeof(numbers)/sizeof(int); i++)
//	{
//		printf(" %d /", numbers[i]);
//	}
//}


void ArraySort3()								// 숫자가 큰 순서로 배열하는 알고리즘 - 삽입정렬(뒤로 미는 개념)
{
	int numbers[5] = { 21, 59, 36, 99, 17 };

	for(int i = 0; i < sizeof(numbers) / sizeof(int); i++)
	{
		for(int j = i - 1; j > 0); j--)
		{
			if(numbers[j] > numbers[i])
			{
				Swap(&numbers[j], &numbers[i]);
			}
		}
	}


	for(int i = 0; i < sizeof(numbers) / sizeof(int); i++)
	{
		printf(" %d /", numbers[i]);
	}

}