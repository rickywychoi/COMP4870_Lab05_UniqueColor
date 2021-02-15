using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

public class DrawDotHub : Hub
{
  public async Task UpdateCanvas(int x, int y, int r, int g, int b, int a)
  {
    await Clients.All.SendAsync("updateDot", x, y, r, g, b, a);
  }

  public async Task ClearCanvas()
  {
    await Clients.All.SendAsync("clearCanvas");
  }
}