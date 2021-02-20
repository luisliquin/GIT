interface Todo {
    title: string;
    description: string;
}

type ParcialTodo = Partial<Todo>;
type ReadOnlyTodo = Readonly<Todo>;

type T = NonNullable<string | number | null | undefined>

type RequiredTodo = Required<Todo>;
