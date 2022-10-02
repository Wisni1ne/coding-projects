'''
Created on Nov 20, 2019

@author: Nathan
'''

# import ModelMethods as mm
# import ProcessData as pd
# import PushResults as pr
# import ReadData as rd
# import UIMethods

from tkinter import *
from tkinter.ttk import *

from PIL import Image, ImageTk

import winsound

# Class to create the program window.
class Window(Frame):
    
    # Initiate program frame.
    def __init__(self, master = None):
        
        Frame.__init__(self, master)
        self.master = master
        self.init_window()
    
    # Create program menu.
    def init_window(self):
        
        self.master.title("TWSS Test")
        self.pack(fill=BOTH, expand=1)

# Initiate tkinter value.
root = Tk()

# Add grid.
mainframe = Frame(root)
mainframe.grid(column=0,row=0, sticky=(N,W,E,S) )
mainframe.columnconfigure(0, weight = 1)
mainframe.rowconfigure(0, weight = 1)
mainframe.pack(pady = 10, padx = 10)

# Load logo image, render for program.
loadlogo = Image.open("twss-logo.png")
renderlogo = ImageTk.PhotoImage(loadlogo)
img = Label(mainframe, image=renderlogo)
img.image = renderlogo
img.grid(row = 0, column = 1)

# Create Tkinter variable.
tkvar = StringVar(root)

# Dictionary with language options.
choices = [ 'English','Spanish','German','Polish','Japanese','Scott' ]

# Create dropdown box for a list of language options.
popupMenu = OptionMenu(mainframe, tkvar, choices[1], *choices)
Label(mainframe, text="Language:").grid(row = 1, column = 1)
popupMenu.grid(row = 2, column =1)

# Space for TWSS text.
l = Label(mainframe, text=" ")
l.grid(row=3,column=1)

# Default option for dropdown box.
tkvar.set('English')

# Change the dropdown value when it does change.
def change_dropdown(*args):
    print( tkvar.get() )

# Link function to change the dropdown box.
tkvar.trace('w', change_dropdown)

# Dependent on the selected dropdown option, 
# display TWSS text in appropriate language
# and play appropriate sound file if sound is on.
def langSel():
    
    if tkvar.get() == 'English':
        
        l = Label(mainframe, text="That's what she said.")
        l.grid(row=3,column=1)
        if sound.get() == "on":
            winsound.PlaySound("twss_eng.wav", winsound.SND_FILENAME)
        l.after(3000, lambda: l.grid_forget())
        
    if tkvar.get() == 'Scott':
        
        l = Label(mainframe, text="That's what she said.")
        l.grid(row=3,column=1)
        if sound.get() == "on":
            winsound.PlaySound("twss_scott.wav", winsound.SND_FILENAME)
        l.after(3000, lambda: l.grid_forget())
                
    if tkvar.get() == 'Spanish':
        
        l = Label(mainframe, text="Eso es lo que ella dijo.")
        l.grid(row=3,column=1)
        if sound.get() == "on":
            winsound.PlaySound("twss_spa.wav", winsound.SND_FILENAME)
        l.after(3000, lambda: l.grid_forget())
        
    if tkvar.get() == 'German':
        
        l = Label(mainframe, text="Das hat sie gesagt.")
        l.grid(row=3,column=1)
        if sound.get() == "on":
            winsound.PlaySound("twss_ger.wav", winsound.SND_FILENAME)
        l.after(3000, lambda: l.grid_forget())
        
    if tkvar.get() == 'Polish':
        
        l = Label(mainframe, text="Tak powiedziała.")
        l.grid(row=3,column=1)
        if sound.get() == "on":
            winsound.PlaySound("twss_pol.wav", winsound.SND_FILENAME)
        l.after(3000, lambda: l.grid_forget())
        
    if tkvar.get() == 'Japanese':
        
        l = Label(mainframe, text="それは彼女が言ったことです。")
        l.grid(row=3,column=1)
        if sound.get() == "on":
            winsound.PlaySound("twss_jap.wav", winsound.SND_FILENAME)
        l.after(3000, lambda: l.grid_forget())

# Clickable to test TWSS text and sound file.
bttn = Button(root, text = "Click me...", command = langSel)
bttn.pack()

# Changes button to sound off, clickable sets to sound on.
def soundoff():
    
    soundBttn.config(image = soundoffimg, command = soundon)
    sound.initialize("off")

# Changes button to sound on, clickable sets to sound off.
def soundon():
    
    soundBttn.config(image = soundonimg, command = soundoff)
    sound.initialize("on")

# String that helps tell functions if sound is on or off.
sound = StringVar(root, "on")

# Image values for sound on and sound off.
soundonimg = PhotoImage(file = "sound-on.png")
soundoffimg = PhotoImage(file = "sound-off.png")

# Clickable to set sound on or sound off. Default set to sound on.
soundBttn = Button(mainframe, image = soundonimg, command = soundoff)
soundBttn.grid(row = 3, column = 1)

# Creates program window.
app = Window(root)

# Loops tkinter.
root.mainloop()

# Main.
if __name__ == '__main__':
    pass


