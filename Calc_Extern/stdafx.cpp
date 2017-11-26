
#include "stdafx.h"

extern "C" double __declspec(dllexport) Calc(double fnum, double snum, char op);

double Calc(double fnum, double snum, char op)
{
	double res;
	switch (op)
	{
	case'+': res = fnum + snum; break;
	case'-': res = fnum - snum; break;
	case'*': res = fnum * snum; break;
	case'/': res = fnum / snum; break;

		return res;
	}
}



