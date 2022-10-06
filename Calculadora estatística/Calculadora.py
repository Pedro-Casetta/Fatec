# import modules
from tkinter import *
from tkinter import messagebox

# configure workspace
Aplicativo = Tk()
Aplicativo.title("Cálculo do tamanho da amostra")
Aplicativo.option_add("*font","Digital-7 20")
Aplicativo.geometry("800x550")
Aplicativo.configure(bg = "#000000")

# function territory
def calculo():
    if EN.get().isdigit() == False:
        messagebox.showerror(title = "Erro", message = "Digite um valor numérico no 'Tamanho da população'!")
    if EE.get().isdigit() == False:
        messagebox.showerror(title = "Erro", message = "Digite um valor numérico no 'Erro amostral'")
    populacao = float(EN.get())
    conf = itens2.get()
    if conf == "90%":
        Z = 1.65
    elif conf == "95%":
        Z = 1.96
    elif conf == "95,5%":
        Z = 2
    elif conf == "99%":
        Z = 2.57
    p = float(EP.get()) / 100
    e = float(EE.get()) / 100
    n = (populacao * (Z ** 2) * p * (1 - p)) / (((e ** 2) * (populacao - 1)) + ((Z ** 2) * p * (1 - p)))
    resposta = Label(Aplicativo, text = f"Tamanho da amostra: {n:.0f}", bg = "#000000", fg = "#09ff00").grid(row = 5, columnspan = 3, pady = (20,10))
    return resposta

def clicar(*args):
    EP.delete(0, "end")

def sair(*args):
    if EP.get().isdigit() == True:
        return EP
    EP.delete(0, "end")
    EP.insert(0, 50)
    Aplicativo.focus()

def limpar():
    itens1.set("")
    itens2.set("90%")
    itens3.set("50")
    itens4.set("")
    limpo = Label(Aplicativo, text = "                                                           ", bg = "#000000", fg = "#09ff00").grid(row = 5, columnspan = 3, pady = (20,10))
    

    

# label & Entry boxes territory
global itens1
global itens2
global itens3
global itens4
LN = Label(Aplicativo, text = "Tamanho da populacao:", pady = 30, bg = "#000000", fg = "#09ff00")
itens1 = StringVar()
EN = Entry(Aplicativo, textvariable = itens1)
EN.config(bg = "#000000", fg = "#09ff00", insertbackground = "#09ff00")
LZ = Label(Aplicativo, text = "Nível de confianca:", pady = 30, bg = "#000000", fg = "#09ff00")
itens2 = StringVar()
itens2.set("90%")
OZ = OptionMenu(Aplicativo, itens2, "90%", "95%", "95,5%", "99%")
OZ.config(bg = "#000000", fg = "#09ff00", highlightthickness = 3, highlightbackground = "#09ff00")
LP = Label(Aplicativo, text= "Estimativa da proporcao (%):", pady = 30, bg = "#000000", fg = "#09ff00")
itens3 = StringVar()
EP = Entry (Aplicativo, textvariable = itens3)
EP.config(bg = "#000000", fg = "#09ff00", insertbackground = "#09ff00")
EP.insert(0, 50)
EP.bind("<Button-1>", clicar)
EP.bind("<Leave>", sair)
LE = Label( Aplicativo, text = "Erro amostral (%):", pady = 40, bg = "#000000", fg = "#09ff00")
itens4 = StringVar()
EE = Entry(Aplicativo, textvariable = itens4)
EE.config(bg = "#000000", fg = "#09ff00", insertbackground = "#09ff00")



# button territory
Calcular = Button(Aplicativo, text = "Calcular", command = calculo, pady = 10, bg = "#000000", fg = "#09ff00", activebackground = "#0045FF")
Limpar = Button(Aplicativo, text = "Limpar", command = limpar, pady = 10, bg = "#000000", fg = "#09ff00", activebackground = "#FF0000")

# Position Provide territory
LN.grid(row = 0, column = 0, padx = (90,20))
EN.grid(row = 0, column = 1)
LZ.grid(row = 1, column = 0, padx = (135,20))
OZ.grid(row = 1, column = 1, ipadx = 90)
LP.grid(row = 2, column = 0, padx = (30,20))
EP.grid(row = 2, column = 1)
LE.grid(row = 3, column = 0, padx = (130,20))
EE.grid(row = 3, column = 1)
Calcular.grid(row = 4, column = 0)
Limpar.grid(row = 4, column = 1)


# infinite loop 
Aplicativo.mainloop()