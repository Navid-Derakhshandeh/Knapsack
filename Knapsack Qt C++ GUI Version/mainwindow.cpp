//Navid-Derakhshandeh
#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}

static double a,a1,b,b1,c,c1,d,d1,e,f,g,h,i,j,k,l,m,n,u,p;
void MainWindow::on_pushButton_clicked()
{
    a = ui->atxt->text().toDouble();
    a1 = ui->a1txt->text().toDouble();
    b = ui->btxt->text().toDouble();
    b1 = ui->b1txt->text().toDouble();
    c = ui->ctxt->text().toDouble();
    c1 = ui->c1txt->text().toDouble();
    d = ui->dtxt->text().toDouble();
    d1 = ui->d1txt->text().toDouble();
    e = a1 / a;
    f = b1 / b;
    g = c1 / c;
    h = d1 / d;
    i = h + e + g;
    j = h + f + g;
    k = e + f + h;
    l = e + f + g;
    if (i > j)
    {
       m = i;
       u = 1;
    }
    else
    {
       m = j;
       u = 2;
    }
    if (k>l)
    {
       n = k;
       p = 3;
    }
    else
    {
       n = l;
       p = 4;
    }
    if(m>n)
    {
       ui->txtres->setText(QString::number(u));
       ui->txtres1->setText(QString::number(m));
    }
    else
    {
       ui->txtres->setText(QString::number(p));
       ui->txtres1->setText(QString::number(n));
    }

}
