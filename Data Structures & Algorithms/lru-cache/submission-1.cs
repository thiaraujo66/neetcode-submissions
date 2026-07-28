public class Node
{
    public int Key;
    public int Val;
    public Node Prev;
    public Node Next;

    public Node(int key, int val)
    {
        Key = key;
        Val = val;
        Prev = null;
        Next = null;
    }
}

public class LRUCache
{
    private readonly int _capacity;
    private readonly Dictionary<int, Node> _cache;
    private readonly Node _left;  // sentinela: extremidade LRU
    private readonly Node _right; // sentinela: extremidade mais recente

    public LRUCache(int capacity)
    {
        _capacity = capacity;
        _cache = new Dictionary<int, Node>();

        _left = new Node(0, 0);
        _right = new Node(0, 0);
        _left.Next = _right;
        _right.Prev = _left;
    }

    // remove o nó da lista
    private void Remove(Node node)
    {
        Node prev = node.Prev;
        Node next = node.Next;
        prev.Next = next;
        next.Prev = prev;
    }

    // insere o nó logo antes do sentinela direito (posição "mais recente")
    private void Insert(Node node)
    {
        Node prev = _right.Prev;
        Node next = _right;
        prev.Next = node;
        next.Prev = node;
        node.Next = next;
        node.Prev = prev;
    }

    public int Get(int key)
    {
        if (_cache.TryGetValue(key, out Node node))
        {
            Remove(node);
            Insert(node); // reinsere no fim -> marca como recém-usado
            return node.Val;
        }
        return -1;
    }

    public void Put(int key, int value)
    {
        if (_cache.TryGetValue(key, out Node existing))
        {
            Remove(existing);
        }

        Node node = new Node(key, value);
        _cache[key] = node;
        Insert(node);

        if (_cache.Count > _capacity)
        {
            // remove o LRU (logo depois do sentinela esquerdo) da lista e do dicionário
            Node lru = _left.Next;
            Remove(lru);
            _cache.Remove(lru.Key);
        }
    }
}