#include <stdio.h>


int main ()
{
	printf("가위=1, 바위=2, 보=3 중 하나를 입력하세요. \n");
	int inputnumber = 0;

	scanf_s("%d", &inputnumber);

	
	printf("%s",(inputnumber == 1) ? "패" : (inputnumber == 2) ? "무승부" : (inputnumber == 3) ? "승" : "반칙패");

	 

}