try:
    with open("C:\Windows\System32\drivers\etc\hosts", "r") as f:
        lines = f.readlines()
    with open("C:\Windows\System32\drivers\etc\hosts", "w") as f:
        for line in lines:
            if line.strip("\n") != "# Anti-Banwave measures for Roblox - added by neoblox":
                f.write(line)
except:
    print("We couldn't deactivate Anti-Banwave due to an unexpected error! Restart the program as an administrator!")

try:
    with open("C:\Windows\System32\drivers\etc\hosts", "r") as f:
        lines = f.readlines()
    with open("C:\Windows\System32\drivers\etc\hosts", "w") as f:
        for line in lines:
            if line.strip("\n") != "127.0.0.1 data.roblox.com":
                f.write(line)
except:
    print("We couldn't deactivate Anti-Banwave due to an unexpected error! Restart the program as an administrator!")

try:
    with open("C:\Windows\System32\drivers\etc\hosts", "r") as f:
        lines = f.readlines()
    with open("C:\Windows\System32\drivers\etc\hosts", "w") as f:
        for line in lines:
            if line.strip("\n") != "127.0.0.1 roblox.sp.backtrace.io":
                f.write(line)  
except:
    print("We couldn't deactivate Anti-Banwave due to an unexpected error! Restart the program as an administrator!")
