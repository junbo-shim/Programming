#include<stdio.h>

int Name(int number)
{
	return number;
}

void PrintFunc(int age)
{
	printf("이대연, 나이: %d, 010-9063", age);
}


int main()
{
	printf("이름: 심준보\n");
	printf("나이: %d세\n", Name(33));
	printf("번호: 010-7355-7069\n");

	PrintFunc(50); 


}