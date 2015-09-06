#include <stdio.h>;
#include <conio.h>;

 int my_Atoi(char* str)
{
    int negative =0;
    int num =0;
    if (str[0] == '-')
    {
        negative = 1;
        str++;
    }
    
    while (*str)
    {
        if (*str >= '0' && *str <= '9')
        {
            int cur = *str - '0';// '0' represents char whose ascii is 48 if you do '0' - '0' = 48-48 =0 same way '1' - '0'= 49-48 = 1 
            num = num*10 + cur;
        }
        else
        {
            break; // throw an error
        }
    str++;
    }
    
    if (negative)
    {
        num = num*-1;
    }
    return num;
    
}

char* my_itoa(int number)
{
    char str[50];
    int i =0;
    unsigned int num;
    
 if (number < 0)
 {
     num = -number;//absolute value in c#
 }
 else 
 {
    num = number;
 }
 
 while (num != 0)
 {
    str[i++] = num %10 + '0';// convert num%10 which is int into char by adding '0'
    num = num/10;
 }
 i--;
 
 if (number < 0 )str[i++] ='-';

//Swap operation to reverse a string
 int j=0;
 for ( ; j <= i/2 ;j++,i--)
 {
     char temp = str[j];
     str[j]= str[i];
     str[i]= temp;
 }
 i++;
 
 //End string with null character
  str[i+j]='\0';
  
  return str;
}


char* my_itoa_base(int number, int base)
{
    char str[50];
    int i=0;
    while (number != 0)
    {
        char c= number % base + '0';//'0' to '9' = 48 to 57 Ascill but 'A' ascii value start from 65
        number = number/ base;
        
       if ( c > 57 )c = c+7; // means c is greater than 9 so it should be A-Z
       str[i++]=c; 
    }
    i--;
    
     //Swap operation to reverse a string
     int j=0;
     for ( ; j <= i/2 ;j++,i--)
     {
         char temp = str[j];
         str[j]= str[i];
         str[i]= temp;
     }
     i++;

     //End string with null character
      str[i+j]='\0';
  
  return str;
}
 

int main()
{
    int ans = my_Atoi("1234");
    printf("%d\n", my_Atoi("1234"));
    
    char* s = my_itoa(1234);
    printf("%s\n", s);
    
    s = my_itoa_base(1234,10);
    printf("%s\n", s);
    
}