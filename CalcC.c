#include <stdlib.h>
#include <stdio.h>
#include <math.h>

void menu();
void menu_text();
int Sum(int a, int b);
int Sub(int a, int b);
int Mult(int a, int b);
int Div(int a, int b);
int Exp(int a, int b);
int Raiz(int a);
int Fact(int a);

int main(){
    int resp=1;
    while(resp!=0){
        menu();
        system("CLS");
        do{
            printf("\nNova conta? (sim-1 / nao-0): ");
            scanf("%d", &resp);
        }while(resp!=0 && resp !=1);
    }
}

void menu(){
    int resp=0,a=0,b=0,cycle=0;
    system("CLS");
    while(resp!=9){
        menu_text();
        scanf("%d", &resp);
        switch (resp){
        case 1:
            if(cycle==0){
                printf("\na+b\n");
                printf("a: ");
                scanf("%d", &a);
            }else printf("\n%d+b\n",a);
            printf("b: ");
            scanf("%d", &b);
            a=Sum(a,b);
            printf("=%d\n", a);
            break;
        case 2:
            if(cycle==0){
                printf("\na-b\n");
                printf("a: ");
                scanf("%d", &a);
            }else printf("\n%d-b\n",a);
            printf("b: ");
            scanf("%d", &b);
            a=Sub(a,b);
            printf("=%d\n", a);
            break;
        case 3:
            if(cycle==0){
                printf("\na*b\n");
                printf("a: ");
                scanf("%d", &a);
            }else printf("\n%d*b\n",a);
            printf("b: ");
            scanf("%d", &b);
            a=Mult(a,b);
            printf("=%d\n", a);
            break;
        case 4:
            if(cycle==0){
                printf("\na/b\n");
                printf("a: ");
                scanf("%d", &a);
            }else printf("\n%d/b\n",a);
            printf("b: ");
            scanf("%d", &b);
            if(b==0){
                printf("Erro, dividir por 0\n");
                cycle--;
                break;
            }
            a=Div(a,b);
            printf("=%d\n", a);
            break;
        case 5:
            if(cycle==0){
                printf("\na^2\n");
                printf("a: ");
                scanf("%d", &a);
            }else printf("\n%d^2\n",a);
            a=Mult(a,a);
            //a=Exp(a,2);
            printf("=%d\n", a);
            break;
        case 6:
            if(cycle==0){
                printf("\na^b\n");
                printf("a: ");
                scanf("%d", &a);
            }else printf("\n%d^b\n",a);
            printf("b: ");
            scanf("%d", &b);
            a=Exp(a,b);
            printf("=%d\n", a);
            break;
        case 7:
            if(cycle==0){
                printf("\nraiz^2 de a\n");
                printf("a: ");
                scanf("%d", &a);
            }else printf("\nraiz^2 de %d\n",a);
            a=Raiz(a);
            printf("=%d\n", a);
            break;
        case 8:
            if(cycle==0){
                printf("\na!\n");
                printf("a: ");
                scanf("%d", &a);
            }else printf("\n%d!\n",a);
            if(a<0){
                printf("Erro, fatorial negativo\n");
                cycle--;
                break;
            }
            a=Fact(a);
            printf("=%d\n", a);
            break;
        case 9:
            break;
        default:
            printf("\nOperacao invalida\n");
            cycle--;
            break;
        }
        cycle++;
    }
}

void menu_text(){
    printf("\n1-Soma\n");
    printf("2-Subtrair\n");
    printf("3-Multiplicar\n");
    printf("4-Dividir\n");
    printf("5-Quadrado\n");
    printf("6-Expoente\n");
    printf("7-Raiz\n");
    printf("8-Fatorial\n");
    printf("9-Sair/Nova conta\n\n");
    printf("R: ");
}

int Sum(int a, int b){
    return a+b;
}

int Sub(int a, int b){
    return a-b;
}

int Mult(int a, int b){
    return a*b;
}

int Div(int a, int b){
    return a/b;
}

int Exp(int a, int b){
    return pow(a,b);
}

/* int Exp(int a, int b){
    int copy=a;
    for (int i = 1; i < b; i++)
    {
        a=a*copy;
    }
    return a;
} */

int Raiz(int a){
    return sqrt(a);
}

/* int Raiz(int a){
    return pow(a,0.5);
} */

int Fact(int a){
    int copy=a;
    while(copy!=1){
        copy--;
        a=a*copy;
    }
    return a;
}