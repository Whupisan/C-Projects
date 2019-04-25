#include "MyForm.h"
#include <cstdlib>
#include <ctime>

using namespace System;
using namespace System::Windows::Forms;


[STAThread]
void Main(array<String^>^ args)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false); srand(static_cast<unsigned int>(time(0)));

	Final_Fun_in_C__::MyForm form;
	Application::Run(%form);
}
