Replace:

choices = [ 'English','Spanish','German','Polish','Japanese','Scott' ]



Add in "def langSel()":

    if tkvar.get() == 'Scott':
        
        l = Label(mainframe, text="That's what she said.")
        l.grid(row=3,column=1)
        if sound.get() == "on":
            winsound.PlaySound("twss_scott.wav", winsound.SND_FILENAME)
        l.after(3000, lambda: l.grid_forget())