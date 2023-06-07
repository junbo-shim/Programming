#include<stdio.h>
#include<stdlib.h>
#include<conio.h>


void Homework();

int main ()
{
	Homework();
	return 0;
}

void Homework()
{

	char man[5] = { 0, };					// 사람의 위치
	for(int i = 0; i < 5; i++)				// i는 0부터 시작해서 4까지 올라간다
	{
		man[i] = '*';						// man[0] = * , man[1] = * ... man[4] = * 
		if (i == 0)
		{
			man[i] = '0';
		}
		printf("%c", man[i]);
	}
}