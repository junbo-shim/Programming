
#include<stdio.h>

/*
void Textout()
{
    printf("%d 를 출력합니다.\n", number);

}
*/ 
int MultiplyThreeNumbers(int number1, int number2, int number3)
{
    printf("입력 값은 %d, %d, %d 입니다.", number1, number2, number3);
    return number1 * number2 * number3;
}

int main()
{
    printf("세 수의 곱은 %d 입니다. \n\n\n", MultiplyThreeNumbers(3, 4, 5));


}