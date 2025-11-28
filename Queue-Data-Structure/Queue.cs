using System;

public class Queue<queueType>
{
	private int MAX_SIZE;
	private bool isEmpty;
	private bool isFull;
	private queueType[] arrayUsedInQueue;
	private int front;
	private int back;
	public Queue(int maxSize)
	{
		this.MAX_SIZE = maxSize;
		this.isEmpty = true;
		this.isFull = false;
		arrayUsedInQueue = new queueType[MAX_SIZE];
		front = 0;
		back = 0;
	}

	public queueType DeQueue()
	{
		queueType output = arrayUsedInQueue[front];
		isFull = false;
		front = (front + 1) % MAX_SIZE;
		if (front == back)
		{
			isEmpty = true;
		}
		return output;
	}
	public void EnQueue(queueType input)
	{
		arrayUsedInQueue[back] = input;
		back = (back + 1) % MAX_SIZE;
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
