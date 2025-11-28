using System;

public class Queue
{
	private int MAX_SIZE;
	private bool isEmpty;
	private bool isFull;
	private int[] arrayUsedInQueue;
	private int front;
	private int back;
	public Queue(int maxSize)
	{
		this.MAX_SIZE = maxSize;
		this.isEmpty = true;
		this.isFull = false;
		arrayUsedInQueue = new int[MAX_SIZE];
		front = 0;
		back = 0;
	}

	public int DeQueue()
	{
		int output = arrayUsedInQueue[front];
		isFull = false;
		front = (front % MAX_SIZE) + 1;
		if (front == back)
		{
			isEmpty = true;
		}
		return output;
	}
	public void EnQueue(int input)
	{
		arrayUsedInQueue[back] = input;
		back = (back % MAX_SIZE) + 1;
		isEmpty = false;
		if (front == back)
		{
			isFull = true;
		}
	}
	public bool IsEmpty()
	{
		return isEmpty;
	}
	public bool IsFull()
	{
		return isFull;
	}
}
