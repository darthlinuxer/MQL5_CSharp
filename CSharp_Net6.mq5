//+------------------------------------------------------------------+
//|                                                  CSharp_Net6.mq5 |
//|                                  Copyright 2024, MetaQuotes Ltd. |
//|                                             https://www.mql5.com |
//+------------------------------------------------------------------+
#property copyright "Copyright 2024, MetaQuotes Ltd."
#property link      "https://www.mql5.com"
#property version   "1.00"

#import "GuiMT_Net6.dll"
#define RAND_MAX 32767
enum DLLEvents
  {
   none, //0
   refreshButtonClicked, //1
   Tab1Clicked, //2
   closeBtnClicked, //3
   valuesLoaded //4
  };

DLLEvents enumEvent = none;
string msgBack = "";

void OnStart()
  {   
   CreateRandomArray();
   MQL5CSharp::ShowForm("Form1");
   while(enumEvent != 3) //3 is closeBtnClicked
     {
      enumEvent = MQL5CSharp::ReadLastEvent();
      if(enumEvent == 1) CreateRandomArray();         
      if(msgBack != MQL5CSharp::ReadInternalMsg())  {  msgBack = MQL5CSharp::ReadInternalMsg();  Print(msgBack); }
      Sleep(100);
     }
  }
double MathRandomBounds(double minValue, double maxValue)
  {
   double f = (MathRand()/(double) RAND_MAX);
   double retValue = minValue + f * (maxValue-minValue);
   return retValue;
  }
void CreateRandomArray()
  {   
   double arr[10];
   for(int index=0; index<10; index++) arr[index]=NormalizeDouble(MathRandomBounds(0,10),1);
   MQL5CSharp::Load(arr);
  }
  
 
