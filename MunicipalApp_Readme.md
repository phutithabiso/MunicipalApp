# 🏙️ Local Events and Announcements Application

## 📘 Overview
The **Local Events and Announcements Application** is a C# program designed to help users discover, filter, and view community events efficiently.  
It integrates **data structures and algorithms** such as **stacks, queues, priority queues, dictionaries, sorted dictionaries, and sets**, and includes an **event recommendation system** that suggests relevant events based on user searches.

---

## 🧠 Objectives
This project demonstrates:
- Application of **data structures** for efficient data management.
- Use of **collections** (Queues, Stacks, Priority Queues, Dictionaries, Sets).
- **Recommendation system** based on user search history.
- A **functional, interactive UI** (Windows Forms or Console-based).

---

## ⚙️ Technical Requirements & Implementation

### 1️⃣ Stacks, Queues, Priority Queues (15 Marks)
**Purpose:** Manage event-related workflows efficiently.  
**Implementation:**
- **Queue** – Handles *upcoming events* in chronological order.  
- **Stack** – Tracks *recently viewed events*.  
- **PriorityQueue** – Prioritizes *urgent events* (soonest first).

```csharp
Queue<Event> upcomingEvents = new Queue<Event>();
Stack<Event> recentlyViewed = new Stack<Event>();
PriorityQueue<Event, DateTime> urgentEvents = new PriorityQueue<Event, DateTime>();
```

---

### 2️⃣ Hash Tables, Dictionaries, Sorted Dictionaries (15 Marks)
**Purpose:** Organize and retrieve event information quickly.  
**Implementation:**
- **Dictionary** – Stores events by title for quick lookups.  
- **SortedDictionary** – Organizes events by date for sorted listings.  
- **HashSet** – Maintains unique event categories.

```csharp
Dictionary<string, Event> eventsByTitle = new Dictionary<string, Event>();
SortedDictionary<DateTime, List<Event>> eventsByDate = new SortedDictionary<DateTime, List<Event>>();
HashSet<string> categories = new HashSet<string>();
```

---

### 3️⃣ Sets (10 Marks)
**Purpose:** Maintain **unique categories or event dates** to avoid duplication.

```csharp
HashSet<string> uniqueCategories = new HashSet<string>();
uniqueCategories.Add("Music");
uniqueCategories.Add("Sports");
```

---

### 4️⃣ Recommendation Feature (30 Marks)
**Purpose:** Suggest related events based on user searches and preferences.

**Implementation Steps:**
1. Track user search frequency in a `Dictionary<string, int>`.
2. Identify the most frequently searched category.
3. Recommend events within that category.

```csharp
Dictionary<string, int> userSearchCounts = new Dictionary<string, int>();

void TrackSearch(string category)
{
    if (userSearchCounts.ContainsKey(category))
        userSearchCounts[category]++;
    else
        userSearchCounts[category] = 1;
}

List<Event> RecommendEvents()
{
    string topCategory = userSearchCounts.OrderByDescending(x => x.Value).First().Key;
    return eventsByTitle.Values.Where(e => e.Category == topCategory).ToList();
}
```

**Output Example:**
```
Recommended Events:
- Music Festival (Music) on 2025/12/01
- Jazz Night (Music) on 2025/12/03
```

---

## 🧩 Data Structure Summary

| Feature | Data Structure | Purpose |
|----------|----------------|----------|
| Upcoming Events | Queue | FIFO order for event scheduling |
| Recently Viewed | Stack | LIFO order for viewing history |
| Urgent Events | PriorityQueue | Prioritize soonest events |
| Event Lookup | Dictionary | Fast lookup by event title |
| Date Sorting | SortedDictionary | Retrieve events by date |
| Unique Categories | HashSet | Prevent duplicate categories |
| Recommendation | Dictionary + Algorithm | Suggest similar events |

---

## 🖥️ How to Run the Project

### **Requirements**
- Visual Studio 2022 or later  
- .NET 6 or newer  
- Windows OS  

### **Steps**
1. Clone or download the project folder.  
2. Open the solution file (`MunicipalApp.sln`) in Visual Studio.  
3. Build the project (`Ctrl + Shift + B`).  
4. Run the application (`F5` or ▶️ button).  
5. Use the filters (category/date) and search events.  
6. The recommendation list updates dynamically based on user activity.

---

## 🧪 Example Features
✅ Search for local events by category or date  
✅ View upcoming and urgent events  
✅ Track recently viewed events  
✅ Automatically get recommendations based on search patterns  
✅ Display unique event categories without duplication  

---

## 🧑‍💻 Author
**Name:** Phaka Phuti Thabiso  

**Module:** Application Development – Data Structures & Algorithms  
**Year:** 2025  

---

## 🏁 Evaluation Summary
| Component | Marks | Description |
|------------|--------|-------------|
| Stacks / Queues / Priority Queues | 15 | Efficient event data management |
| Hash Tables / Dictionaries / Sorted Dictionaries | 15 | Fast search, retrieval, and sorting |
| Sets | 10 | Unique category/date handling |
| Recommendation Feature | 30 | Personalized suggestions |
| **Total** | **70 Marks** | Functional + technical features |
