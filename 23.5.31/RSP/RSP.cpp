#include <stdio.h>


int main ()
{
	printf("가위=1, 바위=2, 보=3 중 하나를 입력하세요. \n");
	int inputnumber = 0;

	scanf_s("%d", &inputnumber);

	
	printf("%s",(inputnumber == 1) ? "승" : (inputnumber == 2) ? "패" : (inputnumber == 3) ? "패" : "반칙패");

	

}